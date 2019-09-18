using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NLH
{
    /// <summary>
    /// Logique d'interaction pour Administrateur.xaml
    /// </summary>
    public partial class Administrateur : Window
    {
        NLHEntities1 myBDD;
        public Administrateur()
        {
           myBDD = new NLHEntities1();
            InitializeComponent();
            

        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text != String.Empty)
            {
                if (txtNom.Text != String.Empty)
                {
                    if (txtPrenom.Text != String.Empty)
                    {

                        if (txtTitre.Text != String.Empty)
                        {


                            Medecien leMedecien = new Medecien();
                            leMedecien.id = txtID.Text.Trim();
                            leMedecien.nom = txtNom.Text.Trim();
                            leMedecien.prenom = txtPrenom.Text.Trim();
                            leMedecien.titre = txtTitre.Text.Trim();
                            myBDD.Medeciens.Add(leMedecien);
                            try
                            {
                                myBDD.SaveChanges();
                                MessageBox.Show("Enregistrement reussi!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }



                        }
                        else
                        {
                            MessageBox.Show("Veuilez  remplir le titre", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);


                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuilez  remplir le prenom", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtPrenom.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Veuilez  remplir les nom", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtNom.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuilez  remplir l'id", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                txtID.Focus();
            }

            //txtID.Text = "";
            //txtNom.Text = "";
            //txtPrenom.Text = "";
            //txtTitre.Text = "";

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Medecien me = new Medecien();
            var query =
                from leMedecin in myBDD.Medeciens
                select new { leMedecin.id, leMedecin.nom, leMedecin.prenom, leMedecin.titre };
            dgMedecin.ItemsSource = query.ToList();

        }

        private void dgMedecin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Medecin sMedecin = new Medecin();
         //   Medecin sMedecin = dgMedecin.SelectedItem  as Medecin;

            //try
            //{



            //txtID.Text = sMedecin.id;
            //txtNom.Text = sMedecin.nom;
            //txtPrenom.Text = sMedecin.prenom;
            //txtTitre.Text = sMedecin.titre;
        }
    }
}
