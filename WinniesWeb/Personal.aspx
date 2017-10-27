<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Personal.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal</title>
    <link href="Styles/login.css" rel="stylesheet" />
    <link href="Styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <img src="Images/winnieslogo.png" width="580" height="190" />
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
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:POSConnectionString %>" SelectCommand="select 0 as id_tienda, 'TODAS LAS SUCURSALES' as nombre
                        UNION 
                        select * from tienda"></asp:SqlDataSource>

                        <br />

                        <dx:ASPxGridView ID="xGridPersonal" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" EnableTheming="True" KeyFieldName="codigo_empleado" Theme="SoftOrange">

                            <Settings ShowFilterRow="True" ShowFooter="True" ShowHeaderFilterButton="True" />
                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" ProcessFocusedRowChangedOnServer="True" />
                            <Columns>
                                <dx:GridViewCommandColumn ShowClearFilterButton="True" ShowDeleteButton="True" VisibleIndex="0">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="codigo_empleado" Caption="Codigo" ReadOnly="True" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="nombre" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="apellido" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="contrasena" VisibleIndex="4">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="codigo_tienda" Caption="Tienda" VisibleIndex="5">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn FieldName="activo" VisibleIndex="6">
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                            <TotalSummary>
                                <dx:ASPxSummaryItem FieldName="codigo_empleado" ShowInColumn="codigo_empleado" SummaryType="Count" />
                            </TotalSummary>

                        </dx:ASPxGridView>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:POSConnectionString %>" DeleteCommand="DELETE FROM [usuario] WHERE [codigo_empleado] = @codigo_empleado" InsertCommand="INSERT INTO [usuario] ([codigo_empleado], [nombre], [apellido], [contrasena], [codigo_tienda], [activo]) VALUES (@codigo_empleado, @nombre, @apellido, @contrasena, @codigo_tienda, @activo)" SelectCommand="SELECT [codigo_empleado], [nombre], [apellido], [contrasena], [codigo_tienda], [activo] FROM [usuario]" UpdateCommand="UPDATE [usuario] SET [nombre] = @nombre, [apellido] = @apellido, [contrasena] = @contrasena, [codigo_tienda] = @codigo_tienda, [activo] = @activo WHERE [codigo_empleado] = @codigo_empleado">
                            <DeleteParameters>
                                <asp:Parameter Name="codigo_empleado" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="codigo_empleado" Type="Int32" />
                                <asp:Parameter Name="nombre" Type="String" />
                                <asp:Parameter Name="apellido" Type="String" />
                                <asp:Parameter Name="contrasena" Type="String" />
                                <asp:Parameter Name="codigo_tienda" Type="Int32" />
                                <asp:Parameter Name="activo" Type="Boolean" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="nombre" Type="String" />
                                <asp:Parameter Name="apellido" Type="String" />
                                <asp:Parameter Name="contrasena" Type="String" />
                                <asp:Parameter Name="codigo_tienda" Type="Int32" />
                                <asp:Parameter Name="activo" Type="Boolean" />
                                <asp:Parameter Name="codigo_empleado" Type="Int32" />
                            </UpdateParameters>
                        </asp:SqlDataSource>

                        <asp:Button runat="server" ID="btnGenerar" OnClick="bntGenerar_Click" Text="Seleccionar" type="submit" class="btn btn-block btn-lg btn-primary" value="Generar" BackColor="Red" />
                        <br />
                        <table>
                            <tr>
                                <td class="text-center">Nombre</td>
                                <td class="text-center">Apellido;</td>
                                <td class="text-center">Sucursal</td>
                                <td class="text-center">&nbsp;</td>
                            </tr>

                            <tr>
                                <td class="text-left">
                                    <asp:TextBox runat="server" ID="txtNombre" /></td>
                                <td class="text-left">
                                    <asp:TextBox runat="server" ID="txtApellido" /></td>
                                <td class="text-center">
                                    <asp:DropDownList ID="dropEditar" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="id_tienda" /></td>
                                <td class="text-center">&nbsp;</td>
                            </tr>

                            <tr>
                                <td class="text-center">Codigo</td>
                                <td class="text-center">Contraseña</td>
                                <td class="text-center">&nbsp;</td>
                                <td class="text-center">&nbsp;</td>
                            </tr>

                            <tr>
                                <td class="text-center">
                                    <asp:TextBox runat="server" ID="txtCodigo" /></td>
                                <td class="text-center">
                                    <asp:TextBox runat="server" ID="txtContrasena" /></td>
                                <td class="text-center">
                                    <asp:CheckBox runat="server" ID="chkActivo" Text="Activo" /></td>
                                <td class="text-center">&nbsp;</td>
                            </tr>
                        </table>
                        <br />
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="descripcion" DataValueField="id_privilegio" RepeatDirection="Horizontal" RepeatColumns="2" RepeatLayout="Table">
                        </asp:CheckBoxList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:POSConnectionString %>" SelectCommand="SELECT [id_privilegio], [descripcion] FROM [privilegios]"></asp:SqlDataSource>
                        <br />
                        <table>
                            <tr>
                                <td class="text-center">
                                    <asp:Button runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Nuevo" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar" BackColor="Red" /></td>
                                <td class="text-center">
                                    <asp:Button runat="server" ID="btnLimpiar" OnClick="btnLimpiar_Click" Text="Limpiar" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar" BackColor="Red" /></td>
                                <td class="text-center">
                                    <asp:Button runat="server" ID="btnEditar" OnClick="btnEditar_Click" Text="Editar" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar" BackColor="Red" /></td>
                                <td class="text-center">
                                    <asp:Label runat="server" ID="lblInfo" /></td>

                            </tr>
                        </table>
                        <br />
                        <asp:Button runat="server" ID="bntSalir" OnClick="bntSalir_Click" Text="Salir" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar" BackColor="Red" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
