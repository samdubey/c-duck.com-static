<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Clients.aspx.cs" Inherits="cduckcs.Clients" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<meta name="title" content="C-DUCK CONSULTANCY SERVICES | CLIENTS" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SideBarContainer" runat="server">
    <div class="sidebarItem">
        <div class="sidebarHeader">
            <h3>
                Our Valuable Clients</h3>
        </div>
        <ul class="basicList">
            <li>
                <p>
                    Tulsi Extrusions Ltd.
                </p>
            </li>
            <li>
                <p>
                    epnotice.com
                </p>
            </li>
            <li>
                <p>
                    Godavari College of Engineering
                </p>
            </li>
            <li>
                <p>
                    Learn From All
                </p>
            </li>
            <li class="noBottomBorder">
                <p>
                    Indrani Solutions
                </p>
            </li>
        </ul>
    </div>
    <!-- end sidebarItem -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="form1">
    <ul id="galleryList">
        <li>
            <h3>
                Tulsi Extrusions Limited</h3>
            <div class="galleryImg">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/clients/tulsi_extrusions.jpg" />
            </div>
            <p>
            </p>
        </li>
        <li>
            <h3>
                EPNotice.com</h3>
            <div class="galleryImg">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/clients/epnotice.png" />
            </div>
            <p>
            </p>
        </li>
        <li>
            <h3>
                Godavari College of Engineering</h3>
            <div class="galleryImg">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/clients/GodavariFoundation.jpg" />
            </div>
            <p>
            </p>
        </li>
        <li>
            <h3>
                Learn From All INC USA.</h3>
            <div class="galleryImg">
                <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/clients/learnfromall.png" />
            </div>
            <p>
            </p>
        </li>
        <li>
            <h3>
                Indrani Solutions</h3>
            <div class="galleryImg">
                <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/clients/indranilogo.gif" />
            </div>
            <p>
            </p>
        </li>
    </ul>
    </form>
</asp:Content>
