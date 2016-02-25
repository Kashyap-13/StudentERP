using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentERP.Models
{
    public class Home
    {
        
    }

    public class login
    {
        public int loginId { get; set; }
        public string email { get; set; }

        public string pwd { get; set; }
    }

    public class change_pwd
    {
        [Display(Name = "Old Password")]
        public string opwd { get; set; }

        [Display(Name = "New Password")]
        public string npwd { get; set; }

        [Display(Name = "Confirm Password")]
        public string cpwd { get; set; }
    }

    public class teacher
    {
        public int TecherId { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

        [Display(Name = "Middlename")]
        public string MiddleName { get; set; }

        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [Display(Name = "Contact no")]
        public decimal ContactNo { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }

        [Display(Name = "Standard")]
        public string name { get; set; }

        [Display(Name = "Level")]
        public int LevelOfStd { get; set; }
    }

    public class division
    {
        public int DivisonID { get; set; }
        [Display(Name = "Division")]
        public string Name { get; set; }
    }

    public class subject
    {
        public int SubjectID { get; set; }
        [Display(Name = "Subject")]
        public string Name { get; set; }
    }

    public class qualification
    {
        public int QualificationId { get; set; }
        [Display(Name = "Qualification")]
        public string Name { get; set; }
    }
    public class occupation
    {
        public int OccupationId { get; set; }
        [Display(Name = "Occupation")]
        public string name { get; set; }
    }

    public class acadamic_year
    {
        public int academicId { get; set; }

        [Display(Name = "Year")]
        public string Year { get; set; }


        [Display(Name = "Is Active Year")]
        public bool isact { get; set; }


    }
    public class year_according_standard
    {
        [Display(Name = "Start Month")]
        public string smonth { get; set; }

        [Display(Name = "End Month")]
        public string emonth { get; set; }

        [Display(Name = "Acadamic Year")]
        public string ayear { get; set; }

        [Display(Name = "Standard")]
        public string astd { get; set; }


        public int yearStandardId { get; set; }
    }

    public class subject_teacher
    {

        [Display(Name = "Subject")]
        public string sub { get; set; }

        [Display(Name = "Teacher Name")]
        public string tname { get; set; }

        [Display(Name = "Acadamic Year")]
        public string acadyear { get; set; }

        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Division")]
        public string div { get; set; }



        public int subjectteacherId { get; set; }
    }

    public class class_teacher
    {
        public int ClassTeacherID { get; set; }

        [Display(Name = "Teacher Name")]
        public string tname { get; set; }

        [Display(Name = "Acadamic Year")]
        public string acadyear { get; set; }

        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Division")]
        public string div { get; set; }
    }

    public class standard_wies_subject
    {
        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Subject")]
        public string sub { get; set; }

        [Display(Name = "Acadamic Year")]
        public string aca { get; set; }

        public int standardvisesubject { get; set; }
    }

    public class standard_wies_division
    {
        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Division")]
        public string divi { get; set; }
        [Display(Name = "Acadamic Year")]
        public string Year { get; set; }

        public int standivid { get; set; }
    }

    public class exam_standard
    {
        [Display(Name = "Exam")]
        public string exam { get; set; }

        [Display(Name = "Standard_Divison")]
        public string std_div { get; set; }
    }

    public class exam
    {
        [Display(Name = "Term")]
        public string term { get; set; }

        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Lable")]
        public string lable { get; set; }
    }

    public class country
    {
        public int CountryId { get; set; }
        [Display(Name = "Country")]
        public string Name { get; set; }
    }

    public class state
    {
        [Display(Name = "Country")]
        public string cntry { get; set; }

        [Display(Name = "State")]
        public string stat { get; set; }
    }

    public class city
    {
        [Display(Name = "State")]
        public string stat { get; set; }

        [Display(Name = "City")]
        public string cty { get; set; }
    }

    public class student_according_acadamic_year
    {
        [Display(Name = "Acadaic Year")]
        public string ayear { get; set; }

        [Display(Name = "Standard_Division")]
        public string std_div { get; set; }

        [Display(Name = "Student Name")]
        public string sname { get; set; }

        [Display(Name = "Roll no.")]
        public string rollno { get; set; }
    }

    public class user
    {
        [Display(Name = "Login Id")]
        public string lgn { get; set; }

        [Display(Name = "Password")]
        public string pwd { get; set; }

        [Display(Name = "First Name")]
        public string fname { get; set; }

        [Display(Name = "Middle Name")]
        public string mname { get; set; }

        [Display(Name = "Last Name")]
        public string lname { get; set; }

        [Display(Name = "Birthdate")]
        public string dob { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }


    }

    public class religion
    {
        public int ReligionID { get; set; }
        [Display(Name = "Religion")]
        public string Name { get; set; }
    }

    public class events
    {
        [Display(Name = "Type")]
        public string typ { get; set; }

        [Display(Name = "Title")]
        public string titl { get; set; }

        [Display(Name = "Start Date")]
        public string sdate { get; set; }

        [Display(Name = "End Date")]
        public string edate { get; set; }

        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Division")]
        public string divi { get; set; }

        [Display(Name = "Description")]
        public string descrp { get; set; }
    }

    public class notification
    {
        [Display(Name = "Title")]
        public string titl { get; set; }

        [Display(Name = "Type")]
        public string typ { get; set; }

        [Display(Name = "Start Date")]
        public string sdate { get; set; }

        [Display(Name = "End Date")]
        public string edate { get; set; }

        [Display(Name = "Standard")]
        public string std { get; set; }

        [Display(Name = "Division")]
        public string div { get; set; }

        [Display(Name = "Student Name")]
        public string sname { get; set; }

        [Display(Name = "Teacher Name")]
        public string tname { get; set; }

        [Display(Name = "Description")]
        public string descrp { get; set; }
    }

    public class assignment_worksheet
    {
        [Display(Name = "Assignment Name")]
        public string aname { get; set; }

        [Display(Name = "Assignment Title")]
        public string atitl { get; set; }

        [Display(Name = "Description")]
        public string descrp { get; set; }

        [Display(Name = "Teacher Name")]
        public string tname { get; set; }

        [Display(Name = "Standard")]
        public string std { get; set; }
    }
}