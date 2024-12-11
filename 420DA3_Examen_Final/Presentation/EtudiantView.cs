using _420DA3_Examen_Final.Business;
using _420DA3_Examen_Final.Business.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_Examen_Final.Presentation;

internal enum ViewActions
{
    Create,
    Update
}

internal partial class EtudiantView : Form
{
    private ViewActions action;
    private FinalApp app;
    private Etudiant? selectedEtudiant;

    public EtudiantView(FinalApp app)
    {
        this.app = app;
        this.InitializeComponent();
    }

    public void Initialize()
    {
        this.etudiantsCoursesValues.Items.AddRange(this.app.CoursService.GetAll().ToArray());
    }

    public void ClearEtudiantDetails()
    {
        this.selectedEtudiant = null;
        this.firstNameValue.Text = "";
        this.lastNameValue.Text = "";
        this.idValue.Value = 0;
        this.etudiantsCoursesValues.SelectedItems.Clear();
    }

    public void LoadEtudiantDetails(Etudiant etudiant)
    {
        this.firstNameValue.Text = etudiant.FirstName;
        this.lastNameValue.Text = etudiant.LastName;
        this.idValue.Value = etudiant.Id;
        this.etudiantsCoursesValues.SelectedItems.Clear();
        foreach (Cours course in etudiant.Courses)
        {
            this.etudiantsCoursesValues.SelectedItems.Add(course);
        }
    }

    private void createEtudiantButton_Click(object sender, EventArgs e)
    {
        this.selectedEtudiant = null;
        this.searchResultsListBox.SelectedItem = null;
        this.searchResultsListBox.SelectedIndex = -1;
        this.actionButton.Text = "Créer";
        this.ClearEtudiantDetails();
        this.actionButton.Enabled = true;
        this.deleteButton.Enabled = false;
        this.action = ViewActions.Create;
    }

    private void searchEtudiantsTextBox_TextChanged(object sender, EventArgs e)
    {
        List<Etudiant> etudiants = this.app.EtudiantService.Search(this.searchEtudiantsTextBox.Text);
        this.searchResultsListBox.Items.Clear();
        this.searchResultsListBox.SelectedItem = null;
        this.searchResultsListBox.SelectedIndex = -1;
        this.searchResultsListBox.Items.AddRange(etudiants.ToArray());
    }

    private void searchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.selectedEtudiant = this.searchResultsListBox.SelectedItem as Etudiant;
        if (this.selectedEtudiant != null)
        {
            this.actionButton.Text = "Sauvegarder";
            this.LoadEtudiantDetails(this.selectedEtudiant);
            this.action = ViewActions.Update;
            this.actionButton.Enabled = true;
            this.deleteButton.Enabled = true;
        }
        else
        {
            this.ClearEtudiantDetails();
            this.actionButton.Enabled = false;
            this.deleteButton.Enabled = false;
        }
    }

    private void actionButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.action == ViewActions.Create)
            {
                Etudiant newEtudiant = new Etudiant
                {
                    FirstName = this.firstNameValue.Text,
                    LastName = this.lastNameValue.Text,
                };
                foreach (Cours cours in this.etudiantsCoursesValues.SelectedItems)
                {
                    newEtudiant.Courses.Add(cours);
                }
                this.app.EtudiantService.Insert(newEtudiant);
                this.searchResultsListBox.Items.Add(newEtudiant);
                this.searchResultsListBox.SelectedItem = newEtudiant;
                MessageBox.Show("L'étudiant a été crée avec succès!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.action == ViewActions.Update)
            {
                this.selectedEtudiant.FirstName = this.firstNameValue.Text;
                this.selectedEtudiant.LastName = this.lastNameValue.Text;

                this.selectedEtudiant.Courses.Clear();
                foreach (Cours cours in this.etudiantsCoursesValues.SelectedItems)
                {
                    this.selectedEtudiant.Courses.Add(cours);
                }
                this.selectedEtudiant = this.app.EtudiantService.Update(this.selectedEtudiant);
                this.LoadEtudiantDetails(this.selectedEtudiant);
                MessageBox.Show("Les informations de l'étudiant ont été mis à jour!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Une erreur est survenue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer cet étudiant?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Etudiant deletedEtudiant = this.app.EtudiantService.Delete(this.selectedEtudiant);
                this.ClearEtudiantDetails();
                this.searchResultsListBox.Items.Remove(deletedEtudiant);
                MessageBox.Show("Étudiant supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Une erreur est survenue lors de la suppression de l'étudiant: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void quitButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Voulez-vous quitter l'application?", "Quitter l'application",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question).ToString() == "Yes")
        {
            Application.Exit();
        }
    }
}
