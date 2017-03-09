﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lebenslauf
{
    public partial class NameOfCV : ContentPage
    {
        public string MainLabel { get; private set; }
        public string Label1 { get; private set; }
        PersonendatenTableItem pdRow;
        DBStorageCV dbcv;

        public NameOfCV()
        {
            InitializeComponent();
            GlobalClass.AppText(this.GetType().Name);
            //Datenbank initialisieren
            dbcv = new DBStorageCV();
            
            LoadData();
            CheckLang();
            BindingContext = this;
        }

        //Daten der Seite laden                        
        void LoadData()
        {
            if (dbcv.dbCon.Table<PersonendatenTableItem>().Count() > 0)
            {
                int id = dbcv.CurrentCVID;
                pdRow = dbcv.dbCon.Get<PersonendatenTableItem>(id);
                NameCV.Text = pdRow.NameCV;
            }
        }

        //Daten der Seite speichern
        void SaveData()
        {
            if (string.IsNullOrEmpty(NameCV.Text))
            {
                NameCV.Text="Lebenslauf_" + dbcv.CurrentCVID;
            }
            var query = dbcv.dbCon.Table<PersonendatenTableItem>().Where(v => v.NameCV == NameCV.Text);
            if (query.Count() > 0)
            {
                pdRow = query.First();
                if (pdRow.ID==dbcv.CurrentCVID)
                {
                    
                }
                else
                {
                    NameCV.Text = NameCV.Text + "_" + dbcv.CurrentCVID;
                }
                
            }
                pdRow = dbcv.dbCon.Get<PersonendatenTableItem>(dbcv.CurrentCVID);
            pdRow.NameCV = NameCV.Text;
            pdRow.GebDat = new DateTime(2000, 01, 01);
            dbcv.dbCon.Update(pdRow);

        }


        void Next_Click(object sender, EventArgs e)
        {
            
            
            SaveData();
            dbcv.dbCon.Close();


            MainPage mv = new MainPage();
            mv.Detail = new NavigationPage(new PersonalInfo());
            App.Current.MainPage = mv;
        }

        void Prev_Click(object sender, EventArgs e)
        {
           
            SaveData();
            dbcv.dbCon.Close();

            MainPage mv = new MainPage();
            mv.Detail = new NavigationPage(new FirstPage());
            App.Current.MainPage = mv;

        }

        void CheckLang()
        {
            int Lang = GlobalClass.LanguagePrg;
            switch (Lang)
            {
                case 1:
                    MainLabel = "Name des Lebenslaufs";
                    Label1 = "Wie soll Ihr Lebenslauf heißen?";
                    break;
                case 2:
                    MainLabel = "Name of CV";
                    Label1 = "What is the name of your resume?";
                    break;
                case 3:
                    MainLabel = "اسم الذاتية";
                    Label1 = "بماذا ترغب أن تسمي سيرتك الذاتية؟";
                    break;


            }

        }

    }
}

