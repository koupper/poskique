<%@ Page Language="C#" AutoEventWireup="true" CodeFile="POS.aspx.cs" Inherits="POS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>POS</title>
    <link href="Styles/login.css" rel="stylesheet" />
    <link href="Styles/styles.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <img src="Images/Winnieslogo.png" width="580" height="190" />
                    <div id='menu'>
                        <ul>
                            <li class='active'><a href="Reportes.aspx">Reportes</a></li>
                            <li><a href="Personal.aspx">Personal</a></li>
                            <li><a href="Inventarios.aspx">Inventarios</a></li>
                            <li><a href='#'>Tiendas</a></li>
                            <li><a href='POS.aspx'>POS</a></li>
                        </ul>
                    </div>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <div id="tabPanel" class="modal-content">
                            <ul class="nav nav-tabs">
                                <li class="active">
                                    <a href="#1" data-toggle="tab">
                                        <asp:Button ID="btnFamilias" runat="server" Text="Familias" OnClick="btnFamilias_Click" /></a>
                                </li>
                                <li>
                                    <a href="#2" data-toggle="tab">
                                        <asp:Button ID="btnIngredientes" runat="server" Text="Ingredientes" OnClick="btnIngredientes_Click" /></a>
                                </li>
                                <li>
                                    <a href="#3" data-toggle="tab">Recetas</a>
                                </li>
                                <li>
                                    <a href="#3" data-toggle="tab">Menu</a>
                                </li>
                                <li>
                                    <a href="#3" data-toggle="tab">Promociones</a>
                                </li>
                            </ul>

                            <div class="tab-content ">
                                <div class="tab-pane active" id="1" style="overflow-x: auto; width: 560px; height: 310px; align-content: center">
                                    <asp:UpdatePanel ID="updTankDetail" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:Button runat="server" ID="btnGenerar" OnClick="bntGenerar_Click" Text="Generar" type="submit" class="btn btn-block btn-lg btn-primary" value="Generar" BackColor="#CC0000" />
                                            <asp:GridView ID="gridFamilias" runat="server" AllowSorting="True" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" OnSelectedIndexChanged="gridFamilias_SelectedIndexChanged">
                                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                                <FooterStyle BackColor="#CCCCCC" />
                                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <RowStyle Wrap="True" />
                                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                                <Columns>
                                                    <asp:CommandField ShowSelectButton="True" ButtonType="Image"
                                                        SelectImageUrl="~/Images/select.png" HeaderText="Seleccion"
                                                        ShowDeleteButton="False" InsertVisible="False" ShowCancelButton="False">
                                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                    </asp:CommandField>
                                                </Columns>
                                            </asp:GridView>
                                            <table>
                                                <tr>
                                                    <th>Agregar o modificar familia:</th>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        Nombre de la familia:</td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtFamilia"/></td>
                                                    <td>
                                                        <asp:Button runat="server" ID="btnActualizar" OnClick="bntActualizar_Click" Text="Actualizar" type="submit" class="btn btn-block btn-lg btn-primary" value="Generar" BackColor="#CC0000" Visible="false" /></td>
                                                </tr>
                                                 <tr>
                                                     <td><asp:Button runat="server" ID="btnNuevo" OnClick="bntNuevo_Click" Text="Nuevo" type="submit" class="btn btn-block btn-lg btn-primary" value="Generar" BackColor="#CC0000" /></td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtID" Visible="false"/>
                                                        <asp:Label runat="server" ID="lblInfo" /></td>
                                                </tr>
                                            </table>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="tab-pane" id="2" style="overflow-x: auto; width: 560px; height: 310px; align-content: center">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="tab-pane" id="3" style="overflow-x: auto; width: 560px; height: 310px; align-content: center">
                                    <h3>add clearfix to tab-content (see the css)</h3>
                                </div>
                                <div class="tab-pane" id="4" style="overflow-x: auto; width: 560px; height: 310px; align-content: center">
                                    <h3>add clearfix to tab-content (see the css)</h3>
                                </div>
                                <div class="tab-pane" id="5" style="overflow-x: auto; width: 560px; height: 310px; align-content: center">
                                    <h3>add clearfix to tab-content (see the css)</h3>
                                </div>
                            </div>
                        </div>


                        <br />
                        <asp:Button runat="server" ID="bntSalir" OnClick="bntSalir_Click" Text="Salir" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
