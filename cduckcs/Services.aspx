<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Services.aspx.cs" Inherits="cduckcs.Services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<meta name="title" content="C-DUCK CONSULTANCY SERVICES | SERVICES | BUSINESS TECHNOLOGY CONSULTING | IT SERVICES | HR SOLUTIONS" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SideBarContainer" runat="server">
    <div class="sidebarItem">
        <div class="sidebarHeader">
            <h3>
                What We Offer</h3>
        </div>
        <ul class="arrowList">
            <li class="activeSidebarItem">Business Technology Consulting</li>
            <li><a href="#" title="">Agile Software Development</a></li>
            <li><a href="#" title="">IT Services</a></li>
            <li><a href="#" title="">Enterprise Solutions</a></li>
            <li><a href="#" title="">Website Development</a></li>
            <li><a href="#" title="">Test Automation</a></li>
            <li class="noBottomBorder"><a href="#" title="">Infrastructure Solutions</a></li>
        </ul>
    </div>
    <!-- end sidebarItem -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <ul id="servicesList">
        <li><a name="book1">
            <img src="Images/serviceImg3.png" alt="Service" class="fl" /></a>
            <h3>
                Business Analysis & Agile Consulting
            </h3>
            <p>
                C-DUCK offers Consulting and Solutions to strategically address these ongoing challenges
                through our experienced team of consultants.</p>
        </li>
        <li><a name="book2">
            <img src="Images/serviceImg3.png" alt="Service" class="fl" /></a>
            <h3>
                AGILE SOFTWARE DEVELOPMENT
            </h3>
            <p>
                Agile Software Development in C-Duck is a mature process of developing various softwares
                using the latest Microsoft technology tools in the highest environment of the development.
            </p>
        </li>
        <li><a name="book1">
            <img src="Images/serviceImg3.png" alt="Service" class="fl" /></a>
            <h3>
                Website development
            </h3>
            <p>
                We develop website development in latest Microsoft Technology such as ASP.NET 4.0,
                MVC with various opensorce and paid libraries to give our customer rich experience.</p>
        </li>
        <li><a name="book1">
            <img src="Images/serviceImg3.png" alt="Service" class="fl" /></a>
            <h3>
                Test Automation
            </h3>
            <p>
                CDUCK has developed test automation with selenium test framework for it's customers.</p>
        </li>
    </ul>
</asp:Content>
