<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inventarios.aspx.cs" Inherits="Inventarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inventarios</title>
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
                                <li><a href='#'>POS</a></li>
                            </ul>
                        </div>
                </div>
                <div class="modal-body">
                    <div class="form-group">    
                                          
                        <asp:UpdatePanel ID="panelTiendas" runat="server" UpdateMode="Conditional">
                           <ContentTemplate>
                                                             
                                    <asp:DropDownList ID="dropTiendas" runat="server">
                                    </asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div id="tabPanel" class="modal-content">	
                        <ul class="nav nav-tabs">
			                        <li class="active">
                                        <a  href="#1" data-toggle="tab">
                                            <asp:Button ID="btnExistencia" runat="server" Text ="Existencias" OnClick="btnExistencia_Click"/></a>
			                        </li>
			                        <li>
                                        <a href="#2" data-toggle="tab">Pedidos</a>
			                        </li>
			                        <li>
                                        <a href="#3" data-toggle="tab">Recepción de producto</a>
			                        </li>
		                        </ul>

			                        <div class="tab-content ">
			                          <div class="tab-pane active" id="1" style="overflow-x:auto;width:560px;height:310px; align-content:center">
                                            <asp:UpdatePanel ID="updTankDetail" runat="server" UpdateMode="Conditional">
                                                <ContentTemplate>

                                                    <asp:GridView ID="gridExistencias" runat="server" AllowSorting="True" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"  OnSelectedIndexChanging="grid_Select">
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
                                                            SelectImageUrl="~/Images/editar.jpg" HeaderText="Seleccion"
                                                            ShowDeleteButton="False" InsertVisible="False" ShowCancelButton="False">
                                                            <itemstyle horizontalalign="Center"></itemstyle>
                                                        </asp:CommandField>
                                                        </Columns>
                                                    </asp:GridView>

                                                </ContentTemplate>
                                            </asp:UpdatePanel>
				                        </div>
				                        <div class="tab-pane" id="2">
                                            <h3>Notice the gap between the content and tab after applying a background color</h3>
				                        </div>
                                        <div class="tab-pane" id="3">
                                            <h3>add clearfix to tab-content (see the css)</h3>
				                        </div>
			                        </div>
                          </div>


                        <br />     
                        <asp:Button runat="server" ID="bntSalir" OnClick="bntSalir_Click" Text="Salir" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar"/>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
	<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
</body>
</html>
