<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/NoLogout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MuskokaCamp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">

            <div class="col-md-4"></div>

            <div class="col-md-4 text-center" id="content">
                <img src="Images/logo.png" alt="Muskoka Discovery Centre Logo" height="180" width="220" />
                <h4>Muskoka Discovery Centre</h4>
                <h2>DAY CAMP PROGRAM</h2>

                <div class="col-md-6 ">
                      
                    <asp:LinkButton href="Parent/CamperAttendence.aspx"  runat="server" cssclass="btn btn-primary btn-banner">Parent / Guardian</asp:LinkButton>
                </div>
                <div class="col-md-6">
                    <!-- Trigger the modal with a button -->
                      <asp:TextBox class="btn btn-primary btn-banner" runat="server" data-toggle="modal" data-target="#myModal">Staff</asp:TextBox>

                      <!-- Modal -->
                      <div class="modal fade" id="myModal" role="dialog">
                        <div class="modal-dialog">
    
                          <!-- Modal content-->
                          <div class="modal-content">
                            <div class="modal-body">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <asp:Panel ID="passPanel" runat="server" DefaultButton="passwordSubmit">
                                <asp:TextBox TextMode="password" ID="password" placeholder="Enter Your Password" UserSubmitBehavior="false" autofocus="true" runat="server" CssClass="table-item"></asp:TextBox>
                              
                                <hr />
                                <asp:LinkButton ID="passwordSubmit" runat="server" OnClick="passwordSubmit_Click" CssClass="btn btn-primary">Submit</asp:LinkButton>                          
                                </asp:Panel>
                            </div>
                          </div>
      
                        </div>
                      </div>
                </div>
            </div>

            <div class="col-md-4"></div>
     </div>
    <script>
        
    </script>
</asp:Content>
