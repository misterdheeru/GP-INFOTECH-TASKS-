<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUpdateDelete.aspx.cs" Inherits="Joins_Crud_Operations.InsertUpdateDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 673px;
        }
        .auto-style4 {
            width: 236px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <center>   
                <br />
                <br />
                <br />

                <br />

            <table >
                <tr>
         <td class="auto-style4">
         <strong>
         Select Department Namer :
   </strong>
   </td>
  <td>
 <asp:DropDownList ID="dropListDept" runat="server" Height="16px" Width="190px" ></asp:DropDownList>
 </td>
                </tr>
                <tr>
                    <td class="auto-style4">

                        <br />

                    </td>
             
                </tr>
            </table>
                <table>
                    <tr>
                        <td>
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  AutoGenerateEditButton="True"  OnRowEditing="GridView1_RowEditing" Height="159px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand"  Width="684px" OnRowUpdating="GridView1_RowUpdating">

       <Columns>
<asp:TemplateField HeaderText="Employee Number"  >
    
      <ItemTemplate>
     <asp:Label ID="LBL1" runat="server" Text='<%#Eval("EmpNo") %>'></asp:Label>
     </ItemTemplate>

     <FooterTemplate>
     <asp:TextBox ID="TxtFooter1" runat="server"></asp:TextBox>
     </FooterTemplate>

 </asp:TemplateField>

<asp:TemplateField HeaderText="Employe Name">

           <ItemTemplate>
           <%#Eval("EmpName") %>
           </ItemTemplate>

         <FooterTemplate>
         <asp:TextBox ID="TxtFooter2" runat="server"></asp:TextBox>
         </FooterTemplate>

</asp:TemplateField>

 <asp:TemplateField HeaderText="Employe Salary">

          <ItemTemplate>
          <%#Eval("Salary") %>
          </ItemTemplate>

        <EditItemTemplate>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </EditItemTemplate>

        <FooterTemplate>
        <asp:TextBox ID="TxtFooter3" runat="server"></asp:TextBox>
        </FooterTemplate>

 </asp:TemplateField>










     
 <asp:TemplateField HeaderText ="Department Name">

               <ItemTemplate>
               <%#Eval(" DeptName") %>
               </ItemTemplate>

  </asp:TemplateField>


  <asp:TemplateField  HeaderText="Insert">
             
    <ItemTemplate> 
    <asp:LinkButton ID="LinkButton1" runat="server" Text="Add" CommandName="add"> 

    </asp:LinkButton>

    <asp:LinkButton ID="LinkButton2" runat="server" Text="Delete " CommandName="d"> 

    </asp:LinkButton>
    </ItemTemplate>
              
    <FooterTemplate>
    <asp:Button ID="Button1" runat="server"   CommandName="save" Text="Save" />
    </FooterTemplate>
   
</asp:TemplateField>


 </Columns>

 </asp:GridView>

                        </td>
                    </tr>
                </table>
                <br />

  
            <br />
           

 
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <strong>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large"></asp:Label>
            </strong>
           

  </center>
            </div>
    </form>
</body>
</html>
