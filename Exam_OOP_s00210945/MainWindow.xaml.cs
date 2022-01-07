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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam_OOP_s00210945
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //list that is accessible by various methods
        List<Member> members;
        List<Member> filteredMembers = new List<Member>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //list of three members
            Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = Member.PaymentSchedule.Annual };
            Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = Member.PaymentSchedule.Biannual };
            Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = Member.PaymentSchedule.Monthly };

            //list of three junior members
            JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = JuniorMember.PaymentSchedule.Annual };
            JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = JuniorMember.PaymentSchedule.Biannual };
            JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = JuniorMember.PaymentSchedule.Monthly };

            //list of three senior members
            SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = SeniorMember.PaymentSchedule.Annual };
            SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = SeniorMember.PaymentSchedule.Biannual };
            SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = SeniorMember.PaymentSchedule.Monthly };

            //add to list
            members = new List<Member>();
            members.Add(m1);
            members.Add(m2);
            members.Add(m3);
            members.Add(jm1);
            members.Add(jm2);
            members.Add(jm3);
            members.Add(sm1);
            members.Add(sm2);
            members.Add(sm3);

            //display on screen
            lbxMain.ItemsSource = members;

       
        }

        private void lbxMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what was selected
            Member selectedMember = lbxMain.SelectedItem as Member;


            //null check
            if (selectedMember != null)
            {
                //take action - display description + cost
                tblckMD.Text = selectedMember.GetMemberDetails();
            }
        }

        private void rbtn_Checked(object sender, RoutedEventArgs e)
        {
            //reset the filter
            filteredMembers.Clear();

            //if all checked, display all
            if (rbtnAll.IsChecked == true)
            {
                lbxMain.ItemsSource = members;
            }


            //else if 1 checked display 1
            else if (rbtnRegular.IsChecked == true)
            {
                foreach (Member member in members)
                {
                    
                        //add to filtered collection
                        filteredMembers.Add(member);
                    
                }
                lbxMain.ItemsSource = filteredMembers;
            }
            //else if 2 checked display 2
            else if (rbtnSenior.IsChecked == true)
            {
                foreach (Member seniorMember in members)
                {

                    //add to filtered collection
                    filteredMembers.Add(seniorMember);

                }
                lbxMain.ItemsSource = filteredMembers;
            }
            //else if 3 checked display 3
            else if (rbtnJunior.IsChecked == true)
            {
                foreach (Member juniorMember in members)
                {

                    //add to filtered collection
                    filteredMembers.Add(juniorMember);

                }
                lbxMain.ItemsSource = filteredMembers;
            }
        }
    }
}


