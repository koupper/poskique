<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Styles/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="modal-dialog">
    <div class="modal-content">
        <div class="modal-header">
          <h1 class="text-center">Bienvenido</h1>
            <asp:Label CssClass="text-center" Text="Bienvenido" ID="lblBien" runat="server" />
        </div>
         <div class="modal-body">
             <div class="form-group">
                 <asp:TextBox runat="server" ID="txtUser" type="text" class="form-control input-lg" placeholder="Usuario"/>
             </div>

             <div class="form-group">
                 <asp:TextBox runat="server" ID="txtPass"  type="password" class="form-control input-lg" placeholder="Contraseña"/>
             </div>

             <div class="form-group">
                 <asp:Button runat="server" ID="bntAceptar" OnClick="bntAceptar_Click" Text="Entrar" type="submit" class="btn btn-block btn-lg btn-primary" value="Entrar"/>
                
             </div>
         </div>
    </div>
 </div>
    </form>
</body>
</html>
