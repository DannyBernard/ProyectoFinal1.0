<%@ Page Title="Registro Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUsuario.aspx.cs" Inherits="ProyectoFinal1._0.Registro.RUsuario" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	  <div class="panel panel-primary">
        <div class="panel-heading">Registro de Usuario</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">
				<%--CategoriaId--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server" ReadOnly="false" placeholder="0" class="form-control input-sm"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                       <asp:LinkButton ID="BuscarLinkButton" runat="server" CssClass="btn btn-primary" OnClick="BuscarLinkButton_Click" ><span class="glyphicon glyphicon-search"></span> Buscar</asp:LinkButton>  
                    </div>
                </div>
				<%--Nombre--%>
                <div class="form-group">
                    <label for="DescripcionTextBox" class="col-md-3 control-label input-sm">Nombre</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="NombreTextBox" runat="server" 
                            Class="form-control input-sm"></asp:TextBox>
						<%--<%-- <%--  <asp:RequiredFieldValidator ID="RFVDescripcion" runat="server" MaxLength="200" 
                            ControlToValidate="DescripcionTextBox" 
                            ErrorMessage="Campo Descripcion obligatorio" ForeColor="Red" 
                            Display="Dynamic" SetFocusOnError="True" 
                            ToolTip="Campo Descripcion obligatorio">Por favor llenar el campo Descripcion
                      </asp:RequiredFieldValidator>--%>
                    </div>
                </div>
				<%--User--%>
                <div class="form-group">
                    <label for="UserTextBox" class="col-md-3 control-label input-sm">User</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="UserTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>
						<%--  <asp:RequiredFieldValidator ID="RFV_MontoTextBox" runat="server" ControlToValidate="PresupuestoTextBox" ErrorMessage="Campo presupuesto obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Monto obligatorio">Por favor llenar el campo Monto</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REV_MontoTextBox" runat="server" ControlToValidate="PresupuestoTextBox" ErrorMessage="No se permiten caracteres en el presupuesto" ForeColor="Red" Dynamic="true" SetFocusOnError="true" ValidationExpression="^(\d|-)?(\d|,)*\.?\d*$">Solo se permiten Números. </asp:RegularExpressionValidator>--%>
                    </div>
                </div>
				<%--PassWord--%>
                <div class="form-group">
                    <label for="PasswordTextBox" class="col-md-3 control-label input-sm">Password</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="PasswordTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>
						<%--  <asp:RequiredFieldValidator ID="RFV_MontoTextBox" runat="server" ControlToValidate="PresupuestoTextBox" ErrorMessage="Campo presupuesto obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Monto obligatorio">Por favor llenar el campo Monto</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="REV_MontoTextBox" runat="server" ControlToValidate="PresupuestoTextBox" ErrorMessage="No se permiten caracteres en el presupuesto" ForeColor="Red" Dynamic="true" SetFocusOnError="true" ValidationExpression="^(\d|-)?(\d|,)*\.?\d*$">Solo se permiten Números. </asp:RegularExpressionValidator>--%>
                    </div>
                </div>
            
				<%--Tipo--%>
                <div class="form-group">
                    <label for="TipoDropDownList" class="col-md-3 control-label input-sm">Tipo de Usuario</label>
                    <div class="col-md-8">
                        <asp:DropDownList ID="TipoDropDownList" runat="server" Class="form-control input-sm">
                            <asp:ListItem Selected="True">[Adminitrador]</asp:ListItem>
							<asp:ListItem Selected="False">[Usuario]</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
				</div>

            <div class="col-md-12">
                <asp:ValidationSummary runat="server" ID="SumaryValidation"
                    ForeColor="red"
                    DisplayMode="BulletList"
                    ShowSummary="true"
                    EnableClientScript="True"
                    Font-Bold="False"
                    CssClass=" alert alert-danger" />
            </div>

            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        </div>

        <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">

                    <asp:Button Text="Nuevo" class="btn btn-warning btn-sm" runat="server" ID="NuevoButton" OnClick="NuevoButton_Click" />
                    <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="GuadarButton" OnClick="GuadarButton_Click"  />
                    <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="EliminarButton" OnClick="EliminarButton_Click" />

                </div>
            </div>

        </div>
    </div>
</asp:Content>
