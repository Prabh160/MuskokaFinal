<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="MuskokaCamp.Parent.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <main class="container">

        <div class="col-md-12 content">
           <section class="tableTitle">
            <h2>Camper Attendance</h2>
            <h3>
                <span class="lblstrong pull-right">
                    <!-- Day of Week -->
                    <asp:Label ID="currentDate" runat="server"></asp:Label>, 
                    <!-- Month Day, Year -->
                    <asp:Label ID="currentDate2" runat="server"></asp:Label>
                </span>
            </h3>
        </section>

            <hr />


            <!-- Default panel contents -->

            <div class="col-md-offset-3 padd-20 col-md-6">

                <div class="form-group">

                    <div class="text-center">
                        <asp:Label for="signedInBy" runat="server" Text="Please Enter Your Name:"></asp:Label>
                    </div>
                    <div class="text-center">
                        <asp:TextBox ID="signedInBy" CssClass="form-control" runat="server" />
                    </div>
                    <div class="text-center marginTop">
                        <asp:Button ID="signin" runat="server" class="btn btn-primary" Text="Sign In" OnClick="signin_Click" />
                    </div>
                </div>

            </div>

        </div>
    </main>

</asp:Content>