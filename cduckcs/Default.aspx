<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="cduckcs._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="SliderContent" runat="server" ContentPlaceHolderID="SliderContainer">
    <!-- Slider Container -->
    <div id="sliderContainer">
        <div class="centerContainer">
            <div id="sliderBtnPrev">
                <img src="Images/btnPrev.png" alt="Previous" />
            </div>
            <div id="mainSlider">
                <ul>
                    <li>
                        <img src="Images/sliderImg1.png" alt="Awesome business cards" class="slideImg fl" />
                        <h1>
                            Welcome to C-DUCK</h1>
                        <p class="sliderParagraph">
                            C-DUCK envisioned and pioneered the adoption of flexible business practices that
                            enables the company to operate more efficiently and produce more values.</p>
                        <div class="blankSeparator">
                            <!-- -->
                        </div>
                        <a class="darkButton fl" href="About.aspx">Read More
                            <img src="Images/darkButtonImg.png" alt="Button" /></a>
                        <p class="additionalOptions fl">
                        </p>
                    </li>
                    <li>
                        <img src="Images/sliderImg1.png" alt="Awesome business cards" class="slideImg fl" />
                        <h1>
                            Sningle : A Social HRMS/HRIS Solution</h1>
                        <p class="sliderParagraph">
                            HRMS system with unique modules to help your organization with HR activities that
                            includes performance management, recruitment management, training management, employee
                            self service for leave, travel, expense, asset.</p>
                        <div class="blankSeparator">
                            <!-- -->
                        </div>
                        <a class="darkButton fl" href="Products.aspx">Read More
                            <img src="Images/darkButtonImg.png" alt="Button" /></a>
                        <p class="additionalOptions fl">
                        </p>
                    </li>
                    <li>
                        <img src="Images/sliderImg1.png" alt="Awesome business cards" class="slideImg fl" />
                        <h1>
                            A Quiz Engine for you</h1>
                        <p class="sliderParagraph">
                            Let's design quizzes and send to target attendees and track their score with C-DUCK's
                            unique micro level score management system.</p>
                        <div class="blankSeparator">
                            <!-- -->
                        </div>
                        <a class="darkButton fl" href="Contact.aspx">Want 1 month free trial! Contact Us
                            <img src="Images/darkButtonImg.png" alt="Button" /></a>
                        <p class="additionalOptions fl">
                        </p>
                    </li>
                    <li>
                        <img src="Images/sliderImg1.png" alt="Awesome business cards" class="slideImg fl" />
                        <h1>
                            Agile Software Development</h1>
                        <p class="sliderParagraph">
                            We do Accelarated Software Delivery using Agile Software Development with our self
                            disciplined team and excellent client coordination process</p>
                        <div class="blankSeparator">
                            <!-- -->
                        </div>
                        <a class="darkButton fl" href="Services.aspx">Read More
                            <img src="Images/darkButtonImg.png" alt="Button" /></a>
                        <p class="additionalOptions fl">
                        </p>
                    </li>
                </ul>
            </div>
            <!-- end sliderContent -->
            <div id="sliderBtnNext">
                <img src="Images/btnNext.png" alt="Next" />
            </div>
        </div>
        <!-- end centerContainer -->
    </div>
    <!-- end sliderContainer -->
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <br />
    <!-- News Container -->
    <div class="centerContainer">
        <div id="leftContainer" class="fl">
            <h3 class="sectionTitle">
                latest <span>news</span></h3>
            <ul id="newsList">
                <li><span>January 15th, 2012</span>
                    <h3>
                        HRMS Version 3.3 Released</h3>
                    <p>
                        Human Resource Management System has new enhancements and features released. available
                        for our esteemed customer to upgrade.</a>.</p>
                </li>
                <li><span>June 1st, 2011</span>
                    <h3>
                        Inventory Managment System beta Version launched</h3>
                    <p>
                        C-Duck Inventory System is the universal program for Inventory Control &amp; Materials
                        Management Software from simple invoicing to complex inventory control system designed
                        specially to meet the requirements of small and medium sized enterprises(SME). C-Duck
                        Inventory System is an intuitive, easy to use, robust , multi-user inventory business
                        management system and accounting software that includes inventory, customer management,
                        vendor management, A/R, A/P and comes with extensive reporting tools.</p>
                    <!--<a href="#" title="Read more" class="readMoreLink style3">Read more</a>-->
                </li>
            </ul>
        </div>
        <!-- end leftContainer -->
        <!-- About Us Container -->
        <div id="rightContainer" class="fr">
            <h3 class="sectionTitle">
                about <span>C-DUCK</span></h3>
            <p>
                &quot;C-DUCK&quot; provides consulting and IT services to its customers. &quot;C-Duck&quot;
                envisioned and pioneered the adoption of flexible business practices that enables
                the company to operate more efficiently and produce more values..</p>
            <blockquote>
                <p>
                    Wow, you guys are just awesome. Makarand in particular was simply amazing, he helped
                    me understand the process so I got around the paperwork so quickly.</p>
                <p>
                    Keep up the good work!</p>
                <p>
                    <strong>Jonathan</strong></p>
            </blockquote>
            <p>
                <strong>Here's some of our satisfied customers:</strong></p>
            <!-- Client List -->
            <div id="clientListContainer">
                <ul>
                    <li>
                        <p>
                            <a href="#" title="">
                                <img src="Images/clients/tulsi_extrusions.jpg" alt="Tulsi Extrusions" />
                            </a>
                        </p>
                    </li>
                    <li>
                        <p>
                            <a href="#" title="">
                                <img src="Images/clients/indraniLogo.gif" alt="Indrani Solutions" /></a></p>
                    </li>
                    <li>
                        <p>
                            <a href="#" title="">
                                <img src="Images/clients/epnotice.png" alt="Epnotice" /></a></p>
                    </li>
                    <li class="noRightBorder">
                        <p>
                            <a href="#" title="">
                                <img src="Images/clients/GodavariFoundation.jpg" alt="Godavari College" /></a></p>
                    </li>
                </ul>
            </div>
            <!-- end clientListContainer -->
        </div>
        <!-- end rightContainer -->
    </div>
    <!-- end centerContainer -->
    <div class="blankSeparator">
        <!-- -->
    </div>
</asp:Content>
