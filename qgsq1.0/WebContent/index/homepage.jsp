<%@ page contentType="text/html; charset=UTF-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>

<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta http-equiv="Page-Enter" content="revealTrans(duration=3, transition=5)" />
<meta http-equiv="Page-Exit" content="revealTrans(duration=3, transition=5)" />
<meta http-equiv="Site-Enter" content="revealTrans(duration=3, transition=5)" />
<meta http-equiv="Site-Exit" content="revealTrans(duration=3, transition=5)" />
<title>主页</title>

<!-- <script language="javascript" type="text/javascript">
$(document).ready(function(){
 $("body").css("display","none");
 $("body").fadeIn(2000); //这个值，自己根据需要设定
});
</script> -->

<script type="text/JavaScript">
<!--
function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}
//-->
</script>
</head>

<body onload="MM_preloadImages('../images/index2_22.png','../images/index2_32.png','../images/index2_42.png')">
<table width="1300" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td><img src="../images/index1.png" width="1300" height="515" /></td>
  </tr>
  <tr>
    <td><table width="1300" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="470"><img src="../images/index2_1.png" width="470" height="40" /></td>
        <td width="140"><a href="${pageContext.request.contextPath}/topicServlet?method=lists" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image6','','../images/index2_32.png',1)"><img src="../images/index2_3.png" name="Image6" width="140" height="40" border="0" id="Image6" /></a></td>
        <td width="130"><a href="${pageContext.request.contextPath}/articleServlet?method=lists" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image5','','../images/index2_22.png',1)"><img src="../images/index2_2.png" name="Image5" width="130" height="40" border="0" id="Image5" /></a></td>
        <td width="120"><a href="${pageContext.request.contextPath}/userServlet?method=userself&&username=${userBean.username}&&password=${userBean.password}" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image7','','../images/index2_42.png',1)"><img src="../images/index2_4.png" name="Image7" width="120" height="40" border="0" id="Image7" /></a></td>
        <td width="440"><img src="../images/index2_5.png" width="440" height="40" /></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td><img src="../images/index3.png" width="1300" height="185" /></td>
  </tr>
</table>
</body>
</html>
