<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reportes.aspx.cs" Inherits="Reportes" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reportes</title>


    <link href="Styles/jquery-ui.min.css" rel="stylesheet" />

    <link href="Styles/login.css" rel="stylesheet" />
    <link href="Styles/styles.css" rel="stylesheet" />
    <style type="text/css">
        #menu {
            height: 50px;
        }
    </style>

    
   <script>
        function reporte(puntos) {
               //  alert('hola');
       
            //Better to construct options first and then pass it as a parameter
            var options = {
                exportEnabled: true,
                animationEnabled: true,
                title: {
                    text: "Exportar gráfica como imagen"
                },
                data: [
		        {
		            type: "splineArea", //change it to line, area, bar, pie, etc
		            dataPoints: puntos
		            
		        }
                ]
            };

            $("#chartContainer").CanvasJSChart(options);

        };
      </script>

     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js" type="text/javascript"></script>

    <script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
    <script type="text/javascript" src="js/jquery.canvasjs.min.js"></script>
    <script src="js/jquery-ui.min.js"></script>
    <script>
        $(document).ready(function () {
            $.ajaxPrefilter(function (options, original_Options, jqXHR) {
                options.async = true;


            });
        });
    </script>
   
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
                        <table>
                            <tr>
                                <td class="text-center">
                                    <asp:DropDownList ID="list1" runat="server" OnSelectedIndexChanged="list1SelectedChanged">
                                        <asp:ListItem Text="Productos favoritos" />
                                        <asp:ListItem Text="Ventas" />
                                        <asp:ListItem Text="Detalles diaros por sucursal" />
                                        <asp:ListItem Selected="true" Text="-----Escoja una reporte----" />
                                    </asp:DropDownList>
                                </td>
                                <td class="text-center">
                                    <asp:DropDownList ID="dropTiendas" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="id_tienda">
                                    </asp:DropDownList>

                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:POSConnectionString %>" SelectCommand="select 0 as id_tienda, 'TODAS LAS SUCURSALES' as nombre
                        UNION 
                        select * from tienda"></asp:SqlDataSource>
                                </td>
                            </tr>

                            <tr>
                                <td class="text-left">
                                    <asp:Label runat="server" Text="Desde:" ID="lblDesde" /></td>
                                <td class="text-left">
                                    <asp:Label runat="server" Text="Hasta:" ID="lblHasta" /></td>
                            </tr>

                            <tr>
                                <td class="text-center">
                                    <asp:TextBox runat="server" ID="txtFecha1" />

                                </td>
                                <td class="text-center">
                                    <asp:TextBox runat="server" ID="txtFecha2" />

                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:Button runat="server" ID="btnGenerar" OnClick="bntGenerar_Click" Text="Generar" type="submit" class="btn btn-block btn-lg btn-primary" value="Generar" BackColor="#CC0000" />
                        <h1 class="text-center">Reporte
                            <asp:Label runat="server" ID="lblReportes"></asp:Label></h1>
                        <asp:Label runat="server" ID="lblInfo" align="center" />
                        <div class="tab-content ">
                            <div class="tab-pane active" id="1" style="overflow-x: auto; width: 560px; height: 310px; align-content: center">
                                <asp:UpdatePanel ID="updTankDetail" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>

                                        <asp:GridView ID="gridReportes" runat="server" AllowSorting="True" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
                                        </asp:GridView>

                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                        <br />
                        <div id="chartContainer" style="height: 300px; width: 100%;">
                            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="261px">
                            </rsweb:ReportViewer>
                        </div>

                        <asp:Button runat="server" ID="bntSalir" OnClick="bntSalir_Click" Text="Salir" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar" BackColor="#CC0000" />
                    </div>
                </div>
            </div>
        </div>

    </form>

    <script>
        $("#txtFecha1").datepicker({
            dateFormat: "dd-mm-yy"
        });

    </script>

    <script>
        $("#txtFecha2").datepicker({
            dateFormat: "dd-mm-yy"
        });
    </script>

</body>
</html>