<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Products.aspx.cs" Inherits="cduckcs.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <meta name="title" content="C-DUCK CONSULTANCY SERVICES | PRODUCTS | HRMS | QUIZ ENGINE | LOYALTY SOLUTIONS" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SideBarContainer" runat="server">
    <div class="sidebarItem">
        <div class="sidebarHeader">
            <h3>
                Our Babies</h3>
        </div>
        <ul class="basicList">
            <li>
                <p>
                    HRMS
                </p>
            </li>
            <li>
                <p>
                    Vehicle Tracking
                </p>
            </li>
            <li>
                <p>
                    loyalty management
                </p>
            </li>
            <li class="noBottomBorder">
                <p>
                    Quiz Engine
                </p>
            </li>
        </ul>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <ul id="galleryList">
        <li>
            <h3>
                <a name="book1">HUMAN RESOURCES MANAGEMENT SYSTEM (HRMS)</a></h3>
            <div class="galleryImg">
                <a href="#">
                    <img src="~/Images/products/hrms.png" runat="server" alt="sningle hrms" /></a></div>
            <p>
                C-DUCK HRMS replaces paper-based, time-consuming and error-prone HR methods with
                a comprehensive set of HR, recruitment, training features. C-DUCK includes web-based
                employee self-service, benefits enrollment and workflow features to keep the workforce
                connected at all times. It also comes with powerful query, reporting and analysis
                tools.</p>
        </li>
        <li>
            <h3>
                <a name="book2">Vehicle tracking system</a></h3>
            <div class="galleryImg">
                <a href="#">
                    <img src="~/Images/products/vechical.png" runat="server" alt="GeoPosition Tracking System" /></a></div>
            <p>
                Let make your vehicle search very easy and help you to track them efficiently with
                our vehicle tracking system. it GPS based tracking for your vehicle(s) as per your
                need and with various customized reports</p>
        </li>
        <%--<li>
            <h3>
                <a name="book3">LOYALTY MANAGEMENT STSTEM</a></h3>
            <div class="galleryImg">
                <a href="#">
                    <img src="Images/products/loyalty.png" alt="LMS" /></a></div>
            <p>
                C-Duck is introducing easy-to-use loyalty Management system software which uses
                the technology of smart cards to reward regular patrons. It is a proven software
                package blending a modern technological infrastructure and a rich set of loyalty
                functionality. It also has Internet based point checking system for each client.
                It has a comprehensive member management module. It is a powerful and compact software
                tool in the hands of the management that provides an efficient way of keeping track
                of members.</p>
        </li>--%>
        <li>
            <h3>
                <a name="book3">Quizy</a></h3>
            <div class="galleryImg">
                <a href="#">
                    <img src="Images/products/quizy.jpg" alt="Quiz Engine" /></a></div>
            <p>
                Are you looking out for the software which allows you to configure the series of
                tests within minutes?</p>
            <p>
                Are you an IT company visiting an educational institute for screening of participants
                through tests?</p>
            <p>
                Are you an educational institute striving to provide practice sessions for campus
                interviews?</p>
            <p>
                Do you still use paper and manpower to grade your participants or employees?</p>
            <p>
                If answer to all of the above queries are YES than we are under utilizing our precious
                resources and wasting papers Why to use papers when we have Quizee – automated quiz
                software
            </p>
        </li>
    </ul>
</asp:Content>
