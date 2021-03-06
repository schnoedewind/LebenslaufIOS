﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lebenslauf
{
    static class GlobalClass
    {
       static string helpstring = "";
        static String mypage = "";
        static int languagePrg = 1;
        public static string HelpString
        {
            get { return helpstring; }
            set { helpstring = value; }
        }
        public static string MyPage
        {
            get { return mypage; }
            set { mypage = value; }
        }
        public static int LanguagePrg
        {
            get { return languagePrg; }
            set { languagePrg = value; }
        }
        public static void AppText(string MyLocation)
        {
            MyPage = MyLocation;
            if (languagePrg==1)
            {
            switch (MyLocation)
            {

                case "PersonalInfo":

                    HelpString = "Wenn Sie auf die Grafik klicken, können Sie ein Bild von Ihnen auswählen, dass auf Ihrem Smartphone gespeichert ist. Das wird dann Ihr Bewerbungsfoto. Bitte achten Sie darauf, dass es ein aktuelles Bild ist.@@Für den Lebenslauf sind dann die persönlichen Daten wichtig.Berühren Sie den Punkt „Anrede“ und wählen „Herr“ oder „Frau“ aus.@@Das Geburtsdatum können Sie komfortabel über die Kalenderfunktion auswählen.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString=HelpString.Replace("@", System.Environment.NewLine);
                    break;
                case "Schools":
                    HelpString = "Welche Schulen haben Sie besucht? Bitte beginnen Sie immer mit der ersten Schule und gehen dann chronologisch vor.@@Um weitere Schulbesuche anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Schulbildung“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;
                case "Ausbildung":
                    HelpString = "Welche Ausbildung oder welches Studium haben Sie absolviert? Gehen Sie auch hier bitte immer chronologisch vor.@@Um weitere Punkte anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Ausbildung / Studium“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "Berufs":
                    HelpString = "Welche berufliche Tätigkeit haben Sie bereits ausgeführt? Gehen Sie auch hier bitte immer chronologisch vor.@@Um weitere Punkte anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Ausbildung / Studium“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "Computer":
                    HelpString = "Wie gut kennen Sie sich mit Computern aus? Notieren Sie bitte zum jeweiligen Betriebssystem / Programm / Programmiersprache über den Punkt „Kenntnisse“ wie fit Sie darin jeweils sind.@@Um weitere Punkte anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „EDV“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;
                case "ContactInfo":
                    HelpString = "Zum Abschluss der persönlichen Informationen sollten Sie noch Ihre Adress- und Kotaktdaten eingeben.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;
                case "CreateDocFile":
                    HelpString = "Haben Sie alle Angaben eingetragen können Sie Ihren Lebenslauf jetzt als Word-Datei ausgeben lassen. Klicken Sie einfach auf das Word-Symbol.@@Diese Word Datei können Sie nun weiter bearbeiten, Sie im Aussehen anpassen, per Mail versenden etc.@@Die Word Datei finden Sie im Dateimanager unter dem Ordner „Lebenslauf“.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "DriveLicsense":
                    HelpString = "Haben Sie einen oder mehrere Fuehrerscheine? Wenn ja, geben Sie bitte noch an für welche „Klasse“.@@Um eine weitere Klasse hinzuzufügen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Fuehrerschein““ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "FirstPage":
                    HelpString = "Wollen Sie einen neuen Lebenslauf erstellen, wählen Sie „Lebenslauf erstellen“.@@Haben Sie bereits einen oder mehrere Lebensläufe erstellt, finden Sie die unter „Lebenslauf bearbeiten“. Wollen Sie einen Lebenslauf als Word Dokument ausgeben, wählen Sie „Lebenslauf bearbeiten“, suchen Sie den Lebenslauf aus, den Sie ausgeben möchten und wählen Sie dann über das Menü „Word Datei erstellen“.@@Unter „Einstellungen“ können Sie die Sprache wechseln.Alternativ ist das an jeder Stelle auch über das Menü „Sprache“ möglich.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "Language":
                    HelpString = "Welche Sprachen sprechen Sie? Geben Sie die entsprechende Sprache ein und wählen Sie über den Punkt „Kenntnisse“ aus, wie gut Sie diese Sprache beherrschen.@@Um weitere Punkte anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Sprachen“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "LanguagePage":
                    HelpString = "";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "MainPage":
                    HelpString = "";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "MoreInfo":
                    HelpString = "Was gibt es sonst noch über Sie zu sagen? Hier haben Sie die Möglichkeit noch weitere Kenntnisse, ehrenamtliche Engagements oder persönliche Angaben zu machen. Bsp.: Dozent an der der VHS seit 2012, Deutscher Meister im Bogenschiessen 2014, körperliche Behinderung laut Ausweis bei 40%, …@@Um weitere Punkte anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Sonstiges“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "MyFeedback":
                    HelpString = "";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "NameOfCV":
                    HelpString = "Um Ihren Lebenslauf speichern zu können, vergeben Sie als erstes bitte einen Namen, z.B. Ihren Vornamen. Unter diesem Namen finden Sie Ihren Lebenslauf dann auch unter dem Punkt „Lebenslauf bearbeiten“ wieder.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "PersonalInfo2":
                    HelpString = "Bitte wählen Sie den „Familienstand“ aus, indem Sie den Punkt berühren.@@Bitte geben Sie bei „Kinder / Alter“ zunächst die Anzahl Ihrer Kinder ein und dann getrennt durch einen Slash / deren jeweiliges Alter. Bsp: 2 / 6, 9@Bei Hobbies können Sie alles eintragen, was Sie gerne in Ihrer Freizeit tun.Bsp.: ehrenamtlicher Fußballtrainer, Wandern, Musik machen.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "Qualifikation":
                    HelpString = "Welche zusätzlichen Qualifikationen haben Sie erworben? Hier können Sie Weiterbildungen, praktische Erfahrungen, Zertifizierungen oder auch Praktika aufführen. Gehen Sie auch hier bitte immer chronologisch vor.@@Um weitere Punkte anzulegen klicken Sie auf das Pluszeichen.@@Die Zahl links unten zeigt an, der wievielte Eintrag unter dem Punkt „Qualifikationen“ es aktuell ist.@@Wollen Sie einen Eintrag wieder löschen, drücken Sie auf das X links unten neben der Zahl.Das X erscheint allerdings erst ab dem 2.Eintrag.@@Über das Speichern Symbol können Sie Ihre Eingaben an jeder Stelle per Hand speichern.@ Sobald Sie aber den Pfeil vorwärts oder rückwärts drücken, speichert die App automatisch die aktuellen Eingaben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "PressPage":
                    HelpString = "Angaben gem. § 5 TMG@@Betreiber und Kontakt:@Visibelle IT-Services Stefan Steinhäuser@Dammer Str. 136 - 138@41066 Mönchengladbach@+49 2161 277 98 41@info @visibelle.de@Ust.- IdNr.: DE813793065@@Berufsspezifische Angaben: @Berufsbezeichnung: Dipl.Ing. (FH) Medientechnik@Verliehen in/ durch: Deutschland@@Berufshaftlichtversicherung@Wir sind bei folgender Versicherung berufshaftpflichtversichert: @R + V Allgemeine Versicherung AG Voltastr. 84 60486 Frankfurt@Berufshaftlicht ist gültig für Deutschland. @@Online - Streitbeilegung gemäß Art. 14 Abs. 1 ODR - VO@Die Europäische Kommission stellt eine Plattform zur Online-Streitbeilegung(OS) bereit, die Sie unter http://ec.europa.eu/consumers/odr/ finden.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "LebenslaufList":
                    HelpString = "Hier finden Sie alle bereits angelegten Lebensläufe. Tippen Sie auf einen Lebenslauf, um ihn weiter zu bearbeiten oder als Word Datei auszugeben.";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

                case "PrivacyPage":
                    HelpString = "An dieser Stelle möchten wir Ihnen aufzeigen, was mit Ihren personenbezogenen Daten geschieht und welche Sicherheitsmaßnahmen zu ihrem Schutz unsererseits getroffen werden. Außerdem werden Sie informiert über Ihre gesetzlich festgelegten Rechte im Zusammenhang mit der Verarbeitung dieser Daten. @Bei der Nutzung unserer App benötigen wir in der Regel keine persönlichen Daten von Ihnen.Lediglich folgende Informationen nehmen wir zur Kenntnis: @@•	Anzahl der aktiven Benutzer pro Tag/ Woche / Monat@•	Durchschnittliche tägliche Anzahl der App - Benutzungen(Sessions) pro Benutzer@•	Gesamtanzahl aller Sessions@•	Durchschnittliche Benutzungsdauer der App in Minuten@•	Die vier meistverwendeten Betriebssysteme@•	Die vier meistverwendeten Handymodelle@•	Eine Statistik des Ortes der Benutzung nach Ländern@•	Eine Statistik über die meistverwendeten Sprachen@•	Die benutzen Versionen der App@•	Absturzberichte der App@Dabei bleiben Sie als Internet - Nutzer jedoch anonym, da wir diese Informationen nur zu statistischen Zwecken auswerten. Unser Webserver steht in Deutschland. @@Persönliche Daten werden nur dann erhoben, wenn Sie uns diese von sich aus angeben.Es besteht natürlich auch die Möglichkeit alternative Kommunikationswege zu nutzen (z.B.Briefpost oder Fax). Personenbezogene Daten sind z.B.Anschriften, Telefonnummern, E - Mailadressen. @@Daten für Beratungs -, Werbe - oder Marktforschungszwecke werden wir nur dann erheben, verarbeiten oder nutzen, wenn Sie uns vorher die Einwilligung dazu gegeben haben. Eine einmal gegebene Einwilligung können Sie natürlich jederzeit widerrufen.Von Kindern und Jugendlichen unter 18 Jahren erheben wir grundsätzlich keine Daten. Sollten Kinder oder Jugendliche personenbezogene Daten an uns übermitteln wollen, sollte dies immer mit Zustimmung der Eltern erfolgen. @@Alle personenbezogenen Daten, die wir im Zuge der Nutzung der App von Ihnen erfahren, werden wir nur zu dem jeweils angegebenen Zweck erheben, verarbeiten und nutzen.Dies geschieht nur im Rahmen der jeweils geltenden Rechtsvorschriften bzw. nur mit Ihrer Einwilligung. Eine Weitergabe oder Verkauf solcher Daten an Dritte schließen wir ausdrücklich aus. @@Unsere Web-Seite enthält auch Links auf die Angebote Dritter.Für die Inhalte und die Datenschutz-/ Sicherheitskonzeption dieser Apps übernehmen wir jedoch keinerlei Verantwortung. @@Um die bei uns gespeicherten Daten unserer Mitarbeiter / Kunden / Lieferanten zu schützen, haben wir entsprechende technische und organisatorische Maßnahmen getroffen.Wir werden unsere Maßnahmen zur Sicherheit und zum Datenschutz immer dann verändern oder anpassen, wenn dies wegen technischer oder rechtlicher Vorgaben notwendig wird. @@Sie als Nutzer haben das Recht, auf Antrag unentgeltlich Auskunft zu erhalten über die personenbezogenen Daten, die über Sie bei uns gespeichert wurden.Zusätzlich haben Sie das Recht auf Berichtigung unrichtiger Daten, Sperrung und Löschung Ihrer personenbezogenen Daten, soweit dem keine gesetzliche Aufbewahrungspflicht entgegensteht. @@Sollten Sie weitere Fragen haben, können Sie sich auch direkt an uns wenden: @@Visibelle IT-Services Stefan Steinhäuser@Dammer Straße 136 - 138@41066 Mönchengladbach@Telefon: +49 21 61 / 277 98 41@Fax: +49 21 61 / 277 94 49@E - Mail: info @visibelle.de";
                    HelpString = HelpString.Replace("@", System.Environment.NewLine);
                    break;

            }
            }

            if (languagePrg == 3)
            {
                switch (MyLocation)
                {

                    case "PersonalInfo":

                        HelpString = "عند النقر على الصورة يمكنك اختيار صورة من الصور المخزنة في الموبايل. هذه الصورة ستكون هي الصورة الخاصة بسيرتك الذاتية. (يرجى التأكد من أن الصورة هي صورتك الحالية)@@ إملأ البنود الخاصة بمعلوماتك و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "Schools":
                        HelpString = "هنا عليك ادخال المدارس التي التحقت بها بشكل متسلسل. @@بعد ادخال اول مدرسة يمكنك الضغط على اشارة الزائد لاضافة المدرسة الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "Ausbildung":
                        HelpString = "هنا قم بادخال التدريب او الدراسة التي انهيتها. يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Berufs":
                        HelpString = "هنا عليك ادخال الخبرات المهنية التي سبق و التحقت بها. يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Computer":
                        HelpString = "هنا عليك ادخال خبراتك في مجال الكمبيوتر و المعلوماتية و مستواك في كل خبرة. يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "ContactInfo":
                        HelpString = "هنا يمكنك اضافة بقية معلوماتك الشخصية و معلومات الاتصال الخاصة بك. يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "CreateDocFile":
                        HelpString = "بعد اكمال الادخالات يمكنك الآن الحصول على ملف وورد يحتوي معلومات سيرتك الذاتية بمجرد الضغط على ايقونة برنامج الوورد و بعدها تستطيع أن تعدل بالملف او ترسله بالطريقة التي تختار.@@ ملف الوورد تستطيع ايجاده عن طريق مدير الملفات تحت المجلد المسمى Lebenslauf";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "DriveLicsense":
                        HelpString = "هنا يمكنك ادخال رخص القيادة التي حصلت عليها. يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "FirstPage":
                        HelpString = "في هذه الصفحة يمكنك انشاء سيرة ذاتية جديدة. أو استعراض السير الذاتية التي تم ادخالها سابقا.@@ و يمكنك ايضا أن تغير لغة القوائم من خلال الضغط على زر الاعدادات.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Language":
                        HelpString = "هنا عليك ادخال اللغات التي تجيدها و مستواك في كل لغة. يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "LanguagePage":
                        HelpString = "";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "MainPage":
                        HelpString = "";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "MoreInfo":
                        HelpString = "هنا يمكنك ادخال خبراتك و شهاداتك الاضافية التي حصلت عليها خلال حياتك العملية.@@ يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "MyFeedback":
                        HelpString = "";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "NameOfCV":
                        HelpString = "هنا يمكنك أن تقوم بتسمية سيرتك الذاتية لسهولة العودة اليها لاحقا.@@ و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "PersonalInfo2":
                        HelpString = "هنا يمكنك أن تقوم باكمال معلوماتك الشخصية و الهوايات التي تقوم بها.@@ ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Qualifikation":
                        HelpString = "هنا يمكنك ادخال كل الكفاءات العملية التي حصلت عليها خلال حياتك العملية و الدورات او التدريبات الاضافية التي اتبعتهاز@@ يمكنك الضغط على اشارة الزائد لاضافة المعلومة  الثانية و هكذا دواليك.@@ الرقم الموجود على اليسار من الأسفل هو اشارة لعدد الإدخالات التي قمت بها. اذا أردت أن تحذف ادخال ما اضغط على اشارة x التي تظهر بعد ثاني ادخال و بمجرد الضغط على السهم التالي أو السابق سيحفظ التطبيق بياناتك تلقائيا.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "PressPage":
                        HelpString = "Angaben gem. § 5 TMG@@Betreiber und Kontakt:@Visibelle IT-Services Stefan Steinhäuser@Dammer Str. 136 - 138@41066 Mönchengladbach@+49 2161 277 98 41@info @visibelle.de@Ust.- IdNr.: DE813793065@@Berufsspezifische Angaben: @Berufsbezeichnung: Dipl.Ing. (FH) Medientechnik@Verliehen in/ durch: Deutschland@@Berufshaftlichtversicherung@Wir sind bei folgender Versicherung berufshaftpflichtversichert: @R + V Allgemeine Versicherung AG Voltastr. 84 60486 Frankfurt@Berufshaftlicht ist gültig für Deutschland. @@Online - Streitbeilegung gemäß Art. 14 Abs. 1 ODR - VO@Die Europäische Kommission stellt eine Plattform zur Online-Streitbeilegung(OS) bereit, die Sie unter http://ec.europa.eu/consumers/odr/ finden.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "LebenslaufList":
                        HelpString = "هنا ستجد جميع السير الذاتية التي تم انشاءها سابقا.@@يمكنك الضغط على السيرة الذاتية و عندها تستطيع تعديل السيرة الذاتية كما تريد.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "PrivacyPage":
                        HelpString = "An dieser Stelle möchten wir Ihnen aufzeigen, was mit Ihren personenbezogenen Daten geschieht und welche Sicherheitsmaßnahmen zu ihrem Schutz unsererseits getroffen werden. Außerdem werden Sie informiert über Ihre gesetzlich festgelegten Rechte im Zusammenhang mit der Verarbeitung dieser Daten. @Bei der Nutzung unserer App benötigen wir in der Regel keine persönlichen Daten von Ihnen.Lediglich folgende Informationen nehmen wir zur Kenntnis: @@•	Anzahl der aktiven Benutzer pro Tag/ Woche / Monat@•	Durchschnittliche tägliche Anzahl der App - Benutzungen(Sessions) pro Benutzer@•	Gesamtanzahl aller Sessions@•	Durchschnittliche Benutzungsdauer der App in Minuten@•	Die vier meistverwendeten Betriebssysteme@•	Die vier meistverwendeten Handymodelle@•	Eine Statistik des Ortes der Benutzung nach Ländern@•	Eine Statistik über die meistverwendeten Sprachen@•	Die benutzen Versionen der App@•	Absturzberichte der App@Dabei bleiben Sie als Internet - Nutzer jedoch anonym, da wir diese Informationen nur zu statistischen Zwecken auswerten. Unser Webserver steht in Deutschland. @@Persönliche Daten werden nur dann erhoben, wenn Sie uns diese von sich aus angeben.Es besteht natürlich auch die Möglichkeit alternative Kommunikationswege zu nutzen (z.B.Briefpost oder Fax). Personenbezogene Daten sind z.B.Anschriften, Telefonnummern, E - Mailadressen. @@Daten für Beratungs -, Werbe - oder Marktforschungszwecke werden wir nur dann erheben, verarbeiten oder nutzen, wenn Sie uns vorher die Einwilligung dazu gegeben haben. Eine einmal gegebene Einwilligung können Sie natürlich jederzeit widerrufen.Von Kindern und Jugendlichen unter 18 Jahren erheben wir grundsätzlich keine Daten. Sollten Kinder oder Jugendliche personenbezogene Daten an uns übermitteln wollen, sollte dies immer mit Zustimmung der Eltern erfolgen. @@Alle personenbezogenen Daten, die wir im Zuge der Nutzung der App von Ihnen erfahren, werden wir nur zu dem jeweils angegebenen Zweck erheben, verarbeiten und nutzen.Dies geschieht nur im Rahmen der jeweils geltenden Rechtsvorschriften bzw. nur mit Ihrer Einwilligung. Eine Weitergabe oder Verkauf solcher Daten an Dritte schließen wir ausdrücklich aus. @@Unsere Web-Seite enthält auch Links auf die Angebote Dritter.Für die Inhalte und die Datenschutz-/ Sicherheitskonzeption dieser Apps übernehmen wir jedoch keinerlei Verantwortung. @@Um die bei uns gespeicherten Daten unserer Mitarbeiter / Kunden / Lieferanten zu schützen, haben wir entsprechende technische und organisatorische Maßnahmen getroffen.Wir werden unsere Maßnahmen zur Sicherheit und zum Datenschutz immer dann verändern oder anpassen, wenn dies wegen technischer oder rechtlicher Vorgaben notwendig wird. @@Sie als Nutzer haben das Recht, auf Antrag unentgeltlich Auskunft zu erhalten über die personenbezogenen Daten, die über Sie bei uns gespeichert wurden.Zusätzlich haben Sie das Recht auf Berichtigung unrichtiger Daten, Sperrung und Löschung Ihrer personenbezogenen Daten, soweit dem keine gesetzliche Aufbewahrungspflicht entgegensteht. @@Sollten Sie weitere Fragen haben, können Sie sich auch direkt an uns wenden: @@Visibelle IT-Services Stefan Steinhäuser@Dammer Straße 136 - 138@41066 Mönchengladbach@Telefon: +49 21 61 / 277 98 41@Fax: +49 21 61 / 277 94 49@E - Mail: info @visibelle.de";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                }
            }

            if (languagePrg == 2)
            {
                switch (MyLocation)
                {

                    case "PersonalInfo":

                        HelpString = "When you click on the picture, you can select a picture of you that is stored on your smartphone. This will be your application photo. Please make sure that it is a current picture. For the curriculum vitae,@@ the personal data is important. Use the item (salutation) and select (Man) or (woman) You can save your entries at any point by hand, but as soon as you press the forward or backward arrow, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "Schools":
                        HelpString = "Which schools did you attend? Please, start with the first school and then start chronologically. @@ To make further school visits please click on the plus sign. @@ The number at the bottom left shows how much entry under (Schulbildung) it is actual. If you want to delete an entry, press the X at the bottom left of the number, but the X appears only from the 2nd entry. @@ You can save your entries at any point by hand using the Save icon Press the arrow forward or backward, the app automatically saves the current input.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "Ausbildung":
                        HelpString = "What training or study did you complete? If you want to create a new entry, please click on the plus sign. @@ The number at the bottom left shows the number of entries under the heading (Education / Studies) If you want to delete the entry, press the X at the bottom left of the number, but the X appears only after the second entry Or backwards, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Berufs":
                        HelpString = "What professional activity have you already carried out? If you want to create a new number, please click on the plus sign. @@ The number at the bottom left shows the number of entries under the heading (Education / Studies) If you want to delete the entry, press the X at the bottom left of the number, but the X appears only after the second entry Or backwards, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Computer":
                        HelpString = "How well do you know about computers? Please write to the respective operating system / program / programming language as you are interested in the respective operating system / program / programming language. @@ To create additional points click on the plus sign. @@ The number at the bottom left shows how much entry under the point If you want to delete an entry, press the X at the bottom left of the number, but the X appears only from the 2nd entry If you press the arrow forward or backward, the app automatically saves the current entries. @@ You can save your input at any point by hand using the Save icon. @ As soon as you move the arrow forward or backward The app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "ContactInfo":
                        HelpString = "To complete your personal information, you should enter your address and contact details. @@ The Save icon allows you to store your entries manually at any point. @ As soon as you press the forward or backward arrow, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;
                    case "CreateDocFile":
                        HelpString = "If you have entered all the details, you can now output your CV as a Word file. Just click on the Word icon. @@ You can now edit this word file, customize it, send it via e-mail, etc. @@ The Word file can be found in the file manager under the (Lebenlauf) folder.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "DriveLicsense":
                        HelpString = "Do you have one or more driving licenses? If yes, please specify for which Type. @@ To add another class, click on the plus sign. @@ The number at the bottom left shows how much entry under the (Driving license) it is actual. @@ If you want to delete an entry, press the X on the lower left of the number, but the X appears only after the second entry @ @ The Save symbol allows you to store your entries manually at any point But you press the arrow forward or backward, the app automatically saves the current input.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "FirstPage":
                        HelpString = "If you want to create a new CV, select (Create CV). @@ If you have already created one or more CVs, see the (Resume CV) section. If you would like to submit a CV as a Word document, select (Edit CV), search for the CV you want to output, then choose (Create Word file) from the menu @@ (Settings) Alternatively, this is possible at any point via the menu (Language).";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Language":
                        HelpString = "Which languages do you speak? Enter the appropriate language and select the degree of proficiency of the language by clicking on the (Knowledge) button. @@ To create additional points, click on the plus sign @@ The number at the bottom left shows the number of entries under the If you want to delete an entry, press the X on the lower left of the number, but the X appears only after the second entry. @@ You can use the Save icon to enter your entries @@ You can use the Save icon to save your input manually at any point, but as soon as you press the forward or backward arrow, the app automatically saves the current input Backwards, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "LanguagePage":
                        HelpString = "";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "MainPage":
                        HelpString = "";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "MoreInfo":
                        HelpString = "What else is there to say about you? Here you have the possibility to make further knowledge, voluntary commitments or personal data. Example: Lecturer at the VHS since 2012, German Champion in Archery 2014, physical handicap according to ID at 40%, ... @@ To create additional points click on the plus sign. @@ The number at the bottom left shows, how many entries If you want to delete an entry again, press the X at the bottom left of the number, but the X appears only from the 2nd entry If you press the arrow forward or backward, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "MyFeedback":
                        HelpString = "";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "NameOfCV":
                        HelpString = "In order to save your CV, please first give a name, e.g. Your first name. Under this name, you will also find your resume under the heading (Edit CV). @@ The Save icon allows you to store your entries manually at any point. @ As soon as you press the forward or backward arrow, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "PersonalInfo2":
                        HelpString = "Please select the (family status) by touching the dot. @@ Please enter the number of children in (Children / Age) and then separated by a slash / their respective age. Example: 2/6, 9 @ For hobbies, you can enter everything you like to do in your spare time.sp: football club, walking, making music @@ You can save your entries at any point by hand . @ As soon as you press the forward or backward arrow, the app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "Qualifikation":
                        HelpString = "What additional qualifications did you earn? Here you can find further training courses, practical experiences, certifications as well as internships. If you want to add more points, click on the plus sign. @@ The number at the bottom left shows the number of entries under (Qualifications) , Press the X at the bottom left of the number, but the X will appear only from the 2nd entry. @@ The Save icon allows you to store your inputs manually at any point, but as soon as you move the arrow forward or backward The app automatically saves the current entries.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "PressPage":
                        HelpString = "Details according to. § 5 TMG @@ Operator and contact: @ Visibelle IT Services Stefan Steinhäuser @ Dammer Str. 136 - 138 @ 41066 Mönchengladbach @ + 49 2161 277 98 41 @ info @ visibelle.de @ VAT ID: DE813793065 @@ Profession specific Details: @Professional Designation: Dipl.Ing. (FH) Medientechnik @ Awarded by: Germany @@ Berufshaftlichtversicherung @ We are covered by the following insurance: @R + V Allgemeine Versicherung AG Voltastr. 84 60486 Frankfurt @ Berufshaftlicht is valid for Germany. @@ Online - Dispute Resolution under Article 14 (1) ODR - Regulation @ The European Commission provides a platform for online dispute settlement (OS), which can be found at http://ec.europa.eu/consumers/odr/.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "LebenslaufList":
                        HelpString = "Here you will find all CVs already created. Tap a resume to continue editing it or output it as a Word file.";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                    case "PrivacyPage":
                        HelpString = "At this point, we would like to show you what is happening with your personal data and what security measures are being taken to protect them. In addition, you will be informed of your legally established rights related to the processing of this data. @For use of our app, we generally do not need any personal data from you. Only the following information is taken: @@ • Number of active users per day / week / month @ • Average daily number of app sessions (sessions) Per user @ • Total number of sessions @ • Average app usage time in minutes @ • The four most frequently used operating systems @ • The four most frequently used handymods @ • Statistics of the usage by country @ • Statistics of the most frequently used languages ​​@ • The versions used Of the app @ • Crash reports of the app @ You remain anonymous as an Internet user, as we only use this information for statistical purposes. Our web server is in Germany. @@ Personal data will only be collected if you give us this information on your own initiative. Of course, there is also the possibility to use alternative communication channels (eg mail or fax). Personal data are, for example, letters, telephone numbers, e - mail addresses. We will only collect, process or use data for consultation, advertising or market research purposes if you have previously given us the consent. You can, of course, revoke your consent at any time. Children and adolescents under the age of 18 are not subject to any data. If children or young people want to transfer personal data to us, this should always be done with the consent of the parents. @@ We will collect, process and utilize all personal data that we have learned from you during the use of the app for the purpose indicated. This is only possible within the framework of the applicable legal regulations or only with your consent. We explicitly exclude the transfer or sale of such data to third parties. @@ Our web site also contains links to third party offers. However, we assume no responsibility for the contents and the privacy / security concept of these apps. @@ In order to protect the data of our employees / customers / suppliers, we have taken appropriate technical and organizational measures. We will change or adapt our safety and data protection measures whenever this is necessary due to technical or legal requirements . @@ You as a user have the right, on request, to receive free of charge information about the personal data that has been stored about you with us. In addition, you have the right to correct incorrect data, blocking and deletion of your personal data, insofar as no legal retention requirement . If you have any further questions, you can also contact us directly: @@ Visibelle IT-Services Stefan Steinhäuser @ Dammerstraße 136 - 138 @ 41066 Mönchengladbach @ Phone: +49 21 61/277 98 41 @ Fax: +49 21 61/277 94 49 @ E-Mail: info @ visibelle.de";
                        HelpString = HelpString.Replace("@", System.Environment.NewLine);
                        break;

                }
            }

        }

}
}
