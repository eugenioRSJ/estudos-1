<%@ Page language="c#" Codebehind="AddReviewsForm.aspx.cs" AutoEventWireup="false" Inherits="ControlMeeting.Controls.AddReviewsForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>AddReviewsForm</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/Geral.css" type="text/css" rel="stylesheet">
		<script language="JavaScript" src="../Js/ObjectsIframe.js"></script>
</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE cellSpacing="0" cellPadding="0" width="400" border="0">
				<TR>
					<TD>
						<TABLE borderColor="#e5e5e5" height="200" cellSpacing="2" cellPadding="2" width="100%"
							align="center" border="0">
							<TR>
								<TD align="center" colSpan="2" valign="top">
									<TABLE borderColor="#e5e5e5" cellSpacing="2" cellPadding="2" width="100%" align="center"
										border="1" runat="server">
										<TR>
											<TD align="center" bgColor="#e5e5e5" colSpan="2"><asp:label id="lblTitle" runat="server">Responder</asp:label></TD>
										</TR>
										<TR>
											<TD align="center" valign="top"><b>Coment�rios:</b></TD>
											<TD align="center">
												<asp:TextBox id="txtReview" runat="server" Width="397px" TextMode="MultiLine" Height="336px"></asp:TextBox>
<asp:RequiredFieldValidator id=rvfValida runat="server" ControlToValidate="txtReview">Coment�rio n�o pode ser vazia</asp:RequiredFieldValidator></TD>
										</TR>
									</TABLE>
									<br>
									<TABLE borderColor="#e5e5e5" cellSpacing="2" cellPadding="2" align="center" border="1">
										<TR>
											<TD align="center" bgColor="#e5e5e5" colSpan="2"><asp:button id="btnSave" runat="server" Width="177px" Text="Salvar"></asp:button></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
