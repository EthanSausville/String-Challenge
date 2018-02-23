<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="String_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>1. Reverse your Name</h2>
            Input your Name:
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="challengeButton1" runat="server" Text="Reverse Your Name" OnClick="challengeButton1_Click" />
            <br />
            <asp:Label ID="resultLabel1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <h2>2. Reverse this sequence: &quot;Luke,Leia,Han,Chewbacca&quot;</h2><br />
            <asp:Button ID="challengeButton2" runat="server" Text="Reorder Items" OnClick="challengeButton2_Click" />
            <br />
            <asp:Label ID="resultLabel2" runat="server"></asp:Label>
            <br />
            <br />
            <h2>3. Pad this sequence with *&#39;s: &quot;Luke,Leia,Han,Chewbacca&quot;</h2>
            Desired String Length:
            <asp:TextBox ID="stringSizeBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="challengeButton3" runat="server" Text="Pad Items" OnClick="challengeButton3_Click" />
            <br />
            <asp:Label ID="resultLabel3" runat="server"></asp:Label>
            <br />
            <br />
            <h2>4. Fix an Ugly String</h2>
            <p>Covert this: &quot;NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.&quot; to this &quot;Now is the time for all good men to come to the aid of their country.&quot;</p>
            <asp:Button ID="challengeButton4" runat="server" Text="Solve" OnClick="challengeButton4_Click" />
            <br />
            <asp:Label ID="resultLabel4" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
