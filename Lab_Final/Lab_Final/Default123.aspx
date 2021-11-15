<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default123.aspx.cs" Inherits="Lab_Final.vaccinated_student" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Comsats || Abbottabad</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
</head>
<body>
	
	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<div class="login100-pic js-tilt" data-tilt>
					<img src="images/img-02.png" alt="IMG">

		<div class="table-responsive text-center">
            <asp:GridView ID="GridView1" runat="server" CssClass="table" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="675px">
            </asp:GridView>
           </div>
				</div>

				<form class="login100-form validate-form">
					<span class="login100-form-title">
						Vaccinated Student
					</span>
					  <div class="text-center">
                 <asp:Label ID="Label7" runat="server" CssClass="alert alert-danger text-danger" Text="Label" Visible="False"></asp:Label>
           </div>
                      <div class="text-center">
                 <asp:Label ID="lblSuccess" runat="server" CssClass="alert alert-success text-success" Text="Label" Visible="False"></asp:Label>
           </div>
					<div class="wrap-input100 validate-input" data-validate = "Valid name is required: ex@abc.xyz">
				
						 <asp:TextBox ID="Name" CssClass="input100" runat="server"></asp:TextBox> 
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>
					<div class="wrap-input100 validate-input" data-validate = "Valid regid is required: ex@abc.xyz">
						 <asp:TextBox ID="RegID" CssClass="input100" runat="server"></asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Valid date vaccination is required: ex@abc.xyz">
						 <asp:TextBox ID="DOV" runat="server" CssClass="input100" TextMode="Date"></asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>
					<div class="wrap-input100 validate-input" data-validate = "Valid vacciine used is required: ex@abc.xyz">
						<asp:TextBox ID="UsedVaccination"  CssClass="input100" runat="server"></asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "No of dosages is required">
						<asp:TextBox ID="NoOfDosadge" CssClass="input100" runat="server" ></asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>
					
					<div class="container-login100-form-btn">
						 <asp:Button ID="Register" runat="server" CssClass="login100-form-btn mb-2 mt-2" Text="Save Vaccination" OnClick="Register_Click" />
					</div>

					<div class="text-center p-t-136">
						<a class="txt2" href="#">
							Copy Right Reserved-Umer Malik
							<i class="fa fa-user m-l-5" aria-hidden="true"></i>
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>
	
	

	
<!--===============================================================================================-->	
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/tilt/tilt.jquery.min.js"></script>
	<script >
		$('.js-tilt').tilt({
			scale: 1.1
		})
    </script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>

</body>
</html>