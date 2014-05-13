<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="content-Type" content="text/html;charset=gb2312">
    <meta name="keywords" content="����arqi��עweb����עǰ�ˣ�js��½ҳ��Ч����Ư���ĵ�������ĵ�¼����" />
    <meta name="description" content="www.arqi.cc,����arqi��עweb����עǰ�ˣ���Ư���ĵ�������ĵ�¼���ڣ�" />
    <title>��ҳ��Ч Ư���ĵ�������ĵ�¼���� ����arqi��עweb����עǰ�ˣ�</title>
    <style type="text/css">
        *
        {
            margin: 0;
            padding: 0;
            font-size: 12px;
            font-weight: normal;
            font-family: verdana, tahoma, helvetica, arial, sans-serif, "����";
            font-style: normal;
            list-style-type: none;
            text-decoration: none;
        }
        /*login*/
        #loginbg
        {
            display: none;
            position: absolute;
            top: 0;
            left: 0;
            z-index: 200;
            height: 100%;
            width: 100%;
            background: #000000;
            filter: alpha(opacity=30);
            -moz-opacity: 0.3;
            opacity: 0.3;
        }
        #login
        {
            position: absolute;
            top: 50%;
            left: 40%;
            width: 293px;
            z-index: 201;
            background: #FFFFFF;
        }
        #login h2 input
        {
            height: 18px;
            width: 18px;
            float: right;
            border: none;
            cursor: pointer;
            margin: 2px 6px 0 0;
        }
        #login h2 a
        {
            display: block;
            float: left;
            width: 83px;
            height: 26px;
            line-height: 26px;
            text-align: center;
            text-decoration: none;
            color: #666;
        }
        #login h2 a.cur
        {
            color: #f00;
        }
        #login ul
        {
            padding: 14px 0 18px 12px;
        }
        #login ul li
        {
            padding-left: 60px;
            margin-top: 10px;
            display: inline-block;
        }
        #login ul li
        {
            display: block;
        }
        #login ul li:after
        {
            content: "youdian";
            clear: both;
            display: block;
            height: 0;
            visibility: hidden;
        }
        #login ul li tt
        {
            float: left;
            width: 60px;
            margin-left: -70px;
            text-align: right;
            line-height: 22px;
            color: #444;
        }
        #login ul li div input.cell, #login ul li div input.cell2
        {
            height: 16px;
            padding: 2px;
            line-height: 16px;
            width: 179px;
            border: 1px #dcdcdc solid;
            color: #666;
        }
        #login ul li div input.cell2
        {
            width: 50px;
        }
        #login ul li div label
        {
            color: #666;
            cursor: pointer;
        }
        #login ul li div img
        {
            margin-bottom: -7px;
            margin-left: 8px;
        }
        * html #login ul li div img
        {
            margin-bottom: -4px;
        }
        * + html #login ul li div img
        {
            margin-bottom: -4px;
        }
        #login ul li div input#fnlogin
        {
            width: 59px;
            height: 21px;
            cursor: pointer;
            border: none;
            margin-right: 15px;
        }
        #login ul li p
        {
            padding-top: 4px;
            color: #f00;
        }
    </style>
    <script type="test/javascript" src="Content/JS/jquery-1.4.1.min.js"></script>
</head>
<body>
    <%--<a href="http://www.arqi.cc" style="font-size: 24px;">����arqi��עweb����עǰ�ˣ���ҳ��Ч Ư���ĵ�������ĵ�¼����
    </a>http://www.arqi.cc--%>
    <hr>
    <!--��ӭ��������arqi��עweb����עǰ�ˣ�Ư���ĵ�������ĵ�¼����-->
    <a href="#" onclick="open_login()" style="font-size: 24px;">��½|</a>
    <div id="loginbg">
    </div>
    <div id="login" style="display: none;">
        <h2>
            <input id="close_login" type="button" title="�˳���¼" value="x" onclick="close_login()" />
            <a name="�û���">�û�����¼</a>
        </h2>
        <ul>
            <form id="LoginForm" name="LoginForm" action="Handler1.ashx" method="post" enctype="multipart/form-data">
            <li>
                <input id="loginType" name="loginType" type="hidden" />
                <tt>
                    <label id="logtype" for="email">
                        �û���:</label></tt>
                <div>
                    <input id="username" name="username" type="text" /></div>
            </li>
            <li><tt>
                <label for="password">
                    �� ��:</label></tt>
                <div>
                    <input id="password" name="password" type="password" /></div>
            </li>
            <li><tt></tt>
                <div>
                    <input id="reme" name="reme" type="checkbox" /><label for="reme">�´��Զ���¼</label>
                </div>
            </li>
            <li><tt></tt>
                <div>
                    <input id="fnlogin" type="button" value="��½"  onclick="logo_in()"/><a href="#">��������</a></div>
            </li>
            </form>
        </ul>
    </div>
    <script language="javascript">
        function open_login() {
            document.getElementById('loginbg').style.display = 'block';
            document.getElementById('login').style.display = 'block';
            showloginbg();
        }
        function close_login() {
            document.getElementById('loginbg').style.display = 'none';
            document.getElementById('login').style.display = 'none';
        }
        function showloginbg() {
            var sWidth, sHeight;
            sWidth = screen.width;
            sWidth = document.body.offsetWidth;
            sHeight = document.body.offsetHeight;
            if (sHeight < screen.height) { sHeight = screen.height; }
            document.getElementById("loginbg").style.width = sWidth + "px";
            document.getElementById("loginbg").style.height = sHeight + "px";
            document.getElementById("loginbg").style.display = "block";
            document.getElementById("loginbg").style.display = "block";
            document.getElementById("loginbg").style.right = document.getElementById("login").offsetLeft + "px";
        }
        function logo_in() {
            var data = {};
            data.uid = $.trim($('#username').val());
            data.pwd = $.trim($('#password').val());
            alert(data.uid);
            close_login();
        };
    </script>
</body>
</html>
