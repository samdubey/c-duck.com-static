<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Contact.aspx.cs" Inherits="cduckcs.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<meta name="title" content="C-DUCK CONSULTANCY SERVICES | CONTACT | BUSINESS TECHNOLOGY CONSULTING | IT SERVICES | HR SOLUTIONS" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarContainer" runat="server">
    <div class="sidebarItem">
        <div class="sidebarHeader">
            <h3>
                CDUCK Contact Information</h3>
        </div>
        <ul class="basicList">
            <li>
                <p>
                    Pune</p>
            </li>
            <li>
                <p>
                    +91 20 26055100</p>
            </li>
            <li class="noBottomBorder">
                <p>
                    info@c-duck.com</p>
            </li>
        </ul>
    </div>
    <!-- end sidebarItem -->
    <div class="sidebarItem">
        <div class="sidebarHeader">
            <h3>
                Driving Directions</h3>
        </div>
        <div class="sidebarGeneral">
            <iframe width="244" height="200" frameborder="0" scrolling="no" marginheight="0"
                marginwidth="0" src="http://maps.google.com/maps?q=CDUCK+CONSULTANCY+SERVICES,+2,First+Floor,+Shree+Guruprasad+Complex,,+628%2F629,+Azad+Lane,Nana+-+Rasta+Peth,+Pune,+Maharashtra,+India&hl=en&ll=18.518024,73.884931&spn=0.055913,0.104628&sll=18.516718,73.867079&sspn=0.001747,0.00327&oq=cduck+consu&t=v&z=14&iwloc=lyrftr:starred_items:114511418738147383533:,8929132784036038831,18.516665,73.866534">
            </iframe>
            <br />
            <small><a href="http://maps.google.com/maps?q=CDUCK+CONSULTANCY+SERVICES,+2,First+Floor,+Shree+Guruprasad+Complex,,+628%2F629,+Azad+Lane,Nana+-+Rasta+Peth,+Pune,+Maharashtra,+India&hl=en&ll=18.518024,73.884931&spn=0.055913,0.104628&sll=18.516718,73.867079&sspn=0.001747,0.00327&oq=cduck+consu&t=v&z=14&iwloc=lyrftr:starred_items:114511418738147383533:,8929132784036038831,18.516665,73.866534"
                style="text-align: left">View Larger Map</a></small>
        </div>
    </div>
    <!-- end sidebarItem -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form action="" method="post" id="contactForm">
    <fieldset>
        <p class="oneHalfCol">
            <label for="name">
                Your Name</label>
            <input type="text" id="name" />
        </p>
        <p class="oneHalfCol">
            <label for="email">
                Your Email Address</label>
            <input type="text" id="email" />
        </p>
        <div class="cl">
            <!-- -->
        </div>
        <p>
            <label for="message">
                Your Message</label>
            <textarea id="message" cols="10" rows="10"></textarea>
        </p>
        <div class="blankSeparator">
            <!-- -->
        </div>
        <a class="redButton fl" onclick="SendEmailContactUs();">Send Message</a>
        <p class="additionalOptions fl">
            <a href="#" onclick="resetform();">Clear</a></p>
    </fieldset>
    </form>
</asp:Content>
