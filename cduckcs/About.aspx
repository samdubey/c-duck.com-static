<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="cduckcs.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<meta name="title" content="C-DUCK CONSULTANCY SERVICES | ABOUT | BUSINESS TECHNOLOGY CONSULTING | IT SERVICES | HR SOLUTIONS" />
</asp:Content>
<asp:Content ID="SideBar" runat="server" ContentPlaceHolderID="SideBarContainer">
    <div class="sidebarItem">
        <div class="sidebarHeader">
            <h3>
                About CDUCK</h3>
        </div>
        <ul class="basicList">
            <li>
                <p>
                    About Us
                </p>
            </li>
            <li class="noBottomBorder">
                <p>
                    Our Strength
                </p>
            </li>
        </ul>
    </div>
    <!-- end sidebarItem -->
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <img src="Images/aboutPageImg.png" alt="About" />
    <h2>
        About Us</h2>
    <p style="text-align: justify">
        We do AGILE software development which brings accelerated delivery. We strongly
        believe in our cross function teams which delivers values to our clients in time
        boxed manner.
    </p>
    <p style="text-align: justify">
        We also provide solutions for a dynamic environment where business and technology
        strategies converge. CDUCK has started with a unique vision of achieving heights
        in Information Technology by caring and serving the people.
    </p>
    <h2>
        Our Strength</h2>
    <p style="text-align: justify">
        <ol>
            <li>Dedicated Teams</li>
            <li>Web Development</li>
            <li>Custom Software Development</li>
            <li>Agile Product Development</li>
            <li>Busienss Analysis Consulting</li>
        </ol>
    </p>
</asp:Content>
