<%@ Page language="c#" Codebehind="NewDir2.aspx.cs" AutoEventWireup="false" Inherits="FTP.NewDir2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Criar Diret�rio</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<style type="text/css">.Font { FONT-SIZE: 11px; FONT-FAMILY: verdana, arial }
	A { FONT-SIZE: 8pt; COLOR: #000000; FONT-FAMILY: verdana, arial; TEXT-DECORATION: none }
	A:visited { FONT-SIZE: 8pt; COLOR: #000000; FONT-FAMILY: verdana, arial; TEXT-DECORATION: none }
	A:hover { FONT-SIZE: 8pt; COLOR: #000000; FONT-FAMILY: verdana, arial; TEXT-DECORATION: none }
	BODY { MARGIN: 0px }
	.campo_branco { BORDER-RIGHT: #666666 1px solid; BORDER-TOP: #666666 1px solid; FONT-SIZE: 10px; BORDER-LEFT: #666666 1px solid; COLOR: #000000; BORDER-BOTTOM: #666666 1px solid; FONT-STYLE: normal; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; BACKGROUND-COLOR: #ffffff }
		</style>
	</HEAD>
	<body class="body">
		<form id="upload" method="post" runat="server" enctype="multipart/form-data">
			<TABLE cellSpacing="10" cellPadding="0" width="100%" border="0" class="Font" id="tblDoUp">
				<TR>
					<TD>Nome:&nbsp;<br>
						<asp:TextBox id="txtNomeDir" runat="server" CssClass="campo_branco" Width="128px" MaxLength="25"></asp:TextBox>
						<asp:Button id="btnCriar" runat="server" Text="Criar" CssClass="campo_branco"></asp:Button><BR>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="O Nome do Diret�rio Obrigat�rio"
							ControlToValidate="txtNomeDir"></asp:RequiredFieldValidator></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>