<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gruyas.Login" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Gruyas.com | Iniciar Sesión</title>    
</head>
<body>
    <form id="LoginForm" runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server" />
        
        <ext:Window 
            ID="LoginWindow" 
            runat="server" 
            Closable="false"
            Resizable="false"
            Height="150" 
            Icon="Lock" 
            Title="Iniciar Sesión"
            Draggable="false"
            Width="350"
            Modal="true"
            BodyPadding="5"
            Layout="Form">
            <Items>
                <ext:TextField 
                    ID="txtEmail" 
                    runat="server" 
                    FieldLabel="Email" 
                    AllowBlank="false"
                    BlankText="Tu email es requerido."
                    />
                <ext:TextField 
                    ID="txtPassword" 
                    runat="server"
                    InputType="Password" 
                    FieldLabel="Contraseña" 
                    AllowBlank="false" 
                    BlankText="Tu contraseña es requerida."
                    />
            </Items>
            <Buttons>
                <ext:Button ID="LoginBtn" runat="server" Text="Ingresar" Icon="Accept" Type="submit" >
                    <DirectEvents>
                        <Click OnEvent="LoginBtn_Click" >
                            <EventMask ShowMask="true" Msg="Verificando..." MinDelay="300" />
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="RegisterBtn" runat="server" Text="Registrarme" Icon="Useradd" >
                    <DirectEvents>
                        <Click OnEvent="RegisterBtn_Click" ></Click>
                    </DirectEvents>
                </ext:Button>
            </Buttons>
        </ext:Window> 

        <ext:Window ID="RegisterUserWindow" 
            runat="server"
            Title="Registrarme!"
            Icon="Useradd"
            Width="300"
            Height="225"
            MinWidth="300"
            MinHeight="225"
            Plain="true" 
            BodyPadding="5"
            ButtonAlign="Center"
            LabelWidth="55"
            Layout="AnchorLayout" 
            CloseAction="hide" 
            Hidden="true">

            <Items>
                <ext:TextField ID="Register_txtName" runat="server" FieldLabel="Nombre" AnchorHorizontal="100%" AllowBlank="false" />
                <ext:TextField ID="Register_txtLastName" runat="server" FieldLabel="Apellido" AnchorHorizontal="100%" AllowBlank="false" />
                <ext:TextField ID="Register_txtEmail" runat="server" FieldLabel="Email" AnchorHorizontal="100%" Vtype="email" AllowBlank="false" />
                <ext:TextField ID="Register_txtPassword" runat="server" FieldLabel="Contraseña" AnchorHorizontal="100%" InputType="Password" AllowBlank="false" />
                <ext:TextField ID="Register_txtRepetePassword" runat="server" FieldLabel="Repetir Contraseña" AnchorHorizontal="100%" InputType="Password" AllowBlank="false" />                
            </Items>
            <Buttons>
                <ext:Button ID="Register_AddNewUser" runat="server" Text="Registrarme!" Icon="tick" >
                    <DirectEvents>
                        <Click OnEvent="Register_AddNewUser_Click" ></Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="Register_CleanFields" runat="server" Text="Limpiar" Icon="TextfieldDelete" >
                    <DirectEvents>
                        <Click OnEvent="Register_CleanFields_Click" ></Click>
                    </DirectEvents>
                </ext:Button>
            </Buttons>
        </ext:Window>
    </form>
</body>
</html>
