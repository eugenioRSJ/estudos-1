<!--#INCLUDE FILE ="chamar_banco.asp"-->
<!--#INCLUDE FILE ="funcao_senha.asp"-->
<!--#INCLUDE FILE ="CPF_CNPJ.asp"-->
<!--#include file="aDOVBS.inc" -->
<%contrario=request("contrario")
imovel=request("imovel")
corretor=request("corretor")
pagina=request("pagina")
radio=request("radio")
pesquisa=request("pesquisa")
opcao=request("opcao")
ordem=request("ordem")
ordem2=request("ordem2")
currentPage = Request( "currentPage" )
IF currentPage = "" THEN currentPage = 1
Set itens = Server.CreateObject( "aDODB.Recordset" ) 
itens.activeConnection = conn
itens.CursorType = 3
itens.PageSize = 3
if ordem="" then
   ordem="interessado"
end if
if pesquisa<>"" then
   if opcao="1" then
      sql="and interessado like '%"&pesquisa&"%' "
   else
      if isdate(pesquisa) and len(pesquisa)=10 then
        sql="and data_contato = convert(datetime,'"&pesquisa&"',103) "
      end if
   end if
end if
itens.Open "select * from contato where status=0 and cod_imovel="&imovel&" "&sql&" ORDER BY "&ordem&" "&ordem2,conn%>
<html>
<head>
<title></title>
<link rel="stylesheet" href="estilo.css">
</head>
<body bgcolor="#f7f7f7" link=black text="#000000" leftmargin="10" topmargin="0" marginwidth="0" marginheight="0" background="../img/bkgd-main.gif">
<br><br>
<table width=90% align="center" bgcolor="white">
  <tr>
    <td class="navdroplist">
      <table width=100% align="center" bgcolor="#FFFFFF">
        <tr>
          <td class="navdroplist">
            <a href="<%=pagina%>.asp?contrario=<%=contrario%>&imovel=<%=imovel%>"><img src="../img/logopb.gif" border=0></a>
          </td>
        </tR>
      </table>
      <br>
      <table width=100% align="center" bgcolor="#f7f7f7" border=0>
        <tr>
          <td class="navdroplist" align=center><B>IMPRIMIR CONTATO(S)</B></td>
        </tR>
      </table>
      <br>
      <table width=100% align="center" bgcolor="#FFFFFF" border=0>
        
        <tr>
          
          <td class="navdroplist">
             SOLICITANTE:&nbsp<b><%=verificador("nome")%></b>
          </td>
        </tr>
        <tr>
          <td class="navdroplist"  width=30%>
            DATA:&nbsp<b><%=date()%></b>
          </td>
          <td class="navdroplist">
             HORA:&nbsp<b><%=time()%></b>
          </td>
          <td class="navdroplist">
           QUANTIDADE DE REGISTRO:&nbsp<b><%=itens.recordcount%></b>
          </td>
          
        </tr>
       
      </table>
      <br>
      <hr>
      <table width=100% align="center" bgcolor="#FFFFFF" border=0>
        <%If itens.EOF = true then%>
        <tr>
          <td align=center></td>
          <td class="navdroplist" width=100%><b>NENHUM REGISTRO ENCONTRADO!</b></td>
        </tR>
        </table>
        <%else%>
           <%do while not itens.eof%>
            <tr>
              <td class="navdroplist" width=130><b>IMOVEL:</b></td>
              <%set imovel = conn.execute("select * from imoveis where codigo="&itens("cod_imovel"))%>
              <td class="navdroplist"><a href="Detalhe_Imovel.asp?codigo=<%=imovel("codigo")%>&pagina=Main_Imoveis"><%=ucase(imovel("descricao"))%></a></td>
            </tr>
            <tr>
              <td class="navdroplist" width=130><b>OP��O:</b></td>
              <%set opcao = conn.execute("select * from opcao where codigo="&itens("cod_opcao"))%>
              <td class="navdroplist" colspan=3><%=ucase(opcao("descricao"))%></td>
            </tr>
            <tr>
              <td class="navdroplist" width=130><b>DESCRI��O:</b></td>
              <td class="navdroplist" colspan=3><%=ucase(itens("descricao"))%></td>
            </tr>
            <tr>
              <td class="navdroplist" width=130><b>INTERESSADO:</b></td>
              <td class="navdroplist" colspan=3><%=ucase(itens("interessado"))%></td>
            </tr>
            <tr>
              <td class="navdroplist" width=130><b>DDD/FONE:</b></td>
              <td class="navdroplist"><%=itens("ddd")%> - <%=itens("fone")%></td><tr>
            </tr>
            <tr>
              <td class="navdroplist" width=130><b>EMAIL:</b></td>
              <td class="navdroplist"><%=ucase(itens("email"))%></td><tr>
            </tr>
            <tr>
              <td class="navdroplist" width=130><b>DATA CONTATO:</b></td>
              <td class="navdroplist"><%=itens("data_contato")%></td><tr>
            </tr>
            <tr><td colspan=4 height=10></td></tr>
            <tr><td bgcolor=#CCCCCC colspan=4 height=3></td></tr>
            <tr><td colspan=4 height=10></td></tr>
          <%itens.MoveNext%>
          <%loop%>   
    </table>
    <%end if%>
    <br>
    <center><a href="javascript:window.print()"><img src="../img/impressora.gif" border=0>&nbspImprimir</a></center>
    </td>
  </tr>
</table>
</body>
</html>