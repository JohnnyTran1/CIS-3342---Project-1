<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="survey.aspx.cs" Inherits="HTML_Form_Controls_Example.survey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Feedback Form</title>
    <link href="Style/surveyResult.css" rel="stylesheet" />
    <link rel="icon" type="image/x-icon" href="Image/TempleUniversityLogo.png">
</head>
<body>
    <form id="form1" runat="server">
    <div class="titleNav">
        <img src="Image/TempleUniveristyName.png" alt="Logo">
        <h1>Feedback Results</h1>
    </div>
    <div class ="Result">
        <asp:Label ID="lblStudentInfo" runat="server"></asp:Label>
        <asp:Label ID="lblCourseAnswers" runat="server"></asp:Label>
        <asp:Label ID="lblProfessorAnswers" runat="server"></asp:Label>
        <asp:Label ID="lblCourseGrade" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblProfessorGrade" runat="server" Text="Label"></asp:Label>

    </div>
    <div id="footer">
            <p>Thank you for your submission!</p>
    </div>
    </form>

    </body>
</html>
