<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inputs.aspx.cs" Inherits="handin_2.Inputs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hand-in #2</title>
    <link href="https://unpkg.com/tailwindcss@^1.0/dist/tailwind.min.css" rel="stylesheet" />
</head>
<body class="bg-gray-200 p-10">
    <form id="form1" runat="server">
        <h1 class="text-center text-6xl text-teal-500 pb-10">Secret agents</h1>
        <div class="flex-column w-full max-w-lg mx-auto">
        
            <asp:TextBox ID="InputName" runat="server" Placeholder="Agent name" CssClass="border rounded w-full p-2 mb-5 text-black-500"></asp:TextBox>

            <asp:TextBox ID="InputLangFirst" runat="server" Placeholder="First language" CssClass="border rounded w-full p-2 mb-5 text-black-500"></asp:TextBox>

            <asp:TextBox ID="InputLangSecond" runat="server" Placeholder="Second language" CssClass="border rounded w-full p-2 mb-5 text-black-500"></asp:TextBox>

            <asp:Button id="CreateAgentBtn" runat="server" Text="Make agent" OnClick="CreateAgent" CssClass="bg-teal-500 hover:bg-teal-700 text-white font-bold py-2 px-4 mb-20 rounded cursor-pointer" />

            <div>
                <asp:ListBox ID="Agents" runat="server" name="Agents" CssClass="w-full"></asp:ListBox><br/>
            </div>
        </div> 
    </form>
</body>
</html>
