<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavyRegistration.aspx.cs" Inherits="Project.NavyRegistration" %>--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavyRegistration.aspx.cs" Inherits="Project.NavyRegistration" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"
        crossorigin="anonymous"></script>
    <style>
        .form-container {
            width: 50%;
            background-color: whitesmoke;
            padding: 20px;
            box-shadow: 0px 0px 10px 5px rgba(0, 0, 0, 0.1);
            overflow:hidden;
        }

        h4 {
            color: rgb(187, 82, 64);
        }

        .gap1 {
            gap: 10rem;
        }

            .gap1 select {
                width: 150%;
            }

            .gap1 input {
                width: 135%;
            }

        .gap2 {
            gap: 9rem;
        }

            .gap2 input {
                width: 140%;
            }

        .gap3 {
            gap: 13rem;
        }

            .gap3 select {
                width: 220%;
            }

        .gap4 {
            gap: 12rem;
        }

        .email {
            width: 95%;
        }

        .date {
            width: 175%;
        }

        .gap5 {
            gap: 10rem;
        }

            .gap5 textarea {
                width: 150%;
            }

        .gap6 {
            gap: 9rem;
        }

            .gap6 input {
                width: 135%;
            }


        .upload-box {
            width: 200px;
            height: 200px;
            border: 3px solid #ccc;
            display: flex;
            align-items: center;
            justify-content: center;
            color: black;
            font-family: Arial, sans-serif;
            font-size: 18px;
            margin-bottom: 20px;
        }

        .upload-button {
            width: 200px;
            height: 50px;
            background-color: #007AFF;
            color: white;
            font-family: Arial, sans-serif;
            font-size: 16px;
            border: none;
            cursor: pointer;
            display: flex;
            align-items: center;
            justify-content: center;
        }
        #dob{
            width:200px;
        }
        #imageuploader{
            background-color:transparent;
        }

        @media only screen and (min-width: 992px) and (max-width: 1350px) {

            .gap1,
            .gap2,
            .gap3,
            .gap4,
            .gap5,
            .gap6 {
                gap: 1rem;
                /* Remove the gap */
            }

                .gap1 select,
                .gap1 input {
                    width: 95%;
                }

                .gap2 input {
                    width: 95%;
                }

                .gap3 select {
                    width: 95%;
                }

            .email {
                width: 95%;
            }

            .date {
                width: 95%;
            }

            .gap5 textarea {
                width: 95%;
            }

            .gap6 input {
                width: 95%;
            }
        }

        @media only screen and (max-width: 992px) {
            .form-container {
                width: 80%;
            }

            .gap1,
            .gap2,
            .gap3,
            .gap4,
            .gap5,
            .gap6 {
                gap: 5rem;
            }

                .gap1 select,
                .gap1 input {
                    width: 120%;
                }

                .gap2 input {
                    width: 120%;
                }

                .gap3 select {
                    width: 120%;
                }

            .email {
                width: 120%;
            }

            .date {
                width: 120%;
            }

            .gap5 textarea {
                width: 120%;
            }

            .gap6 input {
                width: 120%;
            }
        }

        @media only screen and (max-width: 768px) {
            .form-container {
                width: 90%;
            }

            .gap1,
            .gap2,
            .gap3,
            .gap4,
            .gap5,
            .gap6 {
                gap: 2rem;
            }

                .gap1 select,
                .gap1 input {
                    width: 100%;
                }

                .gap2 input {
                    width: 100%;
                }

                .gap3 select {
                    width: 100%;
                }

            .email {
                width: 100%;
            }

            .date {
                width: 100%;
            }

            .gap5 textarea {
                width: 100%;
            }

            .gap6 input {
                width: 100%;
            }
        }

        @media only screen and (max-width: 552px) {
            .form-container {
                width: 80%;
            }

            .gap1,
            .gap2,
            .gap3,
            .gap4,
            .gap5,
            .gap6 {
                gap: 2rem;
            }

                .gap1 select {
                    width: 180%;
                }



                .gap2 input {
                    width: 170%;
                }

                .gap3 select {
                    width: 120%;
                }

            .email {
                width: 165%;
            }

            .date {
                width: 210%;
            }

            .form-group #dob{
                width:200px;
            }

            .gap5 textarea {
                width: 180%;
            }



            .gap6 input {
                width: 165%;
            }
        }
    </style>
</head>

<body>
    <div class="containerrr d-flex justify-content-center align-items-center mt-5 mb-5">
        <form class="form-container " runat="server">
            <h1 class="text-center">Registration Form</h1>
            <div>
                <h4 class="mb-4">Application</h4>
                <div class="form-group mb-4 ">
                    <label for="advertisement" class="form-label">Apply For:</label>
<select class="form-select" id="advertisement" runat="server" name="advertisement">
    <option value="" selected>None</option>
    <option value="navy">Pakistan Navy</option>
    <option value="army">Pakistan Army</option>
    <option value="airforce">Pakistan Airforce</option>           
</select>

                </div>
                <div class="form-group mb-4">
                    <label for="branch" class="form-label">Branch:</label>
                    <select class="form-select ">
                         <option value="" required>--Select Branch / Category / Induction--</option>
                        <option value="" required>--PN / CADET / B-2024--</option>
                       </select>
                </div>
                <div class="d-flex mb-4 gap1 flex-wrap">
                    <div class="form-group ">
                        <label for="pnr&sc" class="form-label">SC:</label>
                        <select class="form-select " id="pnr&sc">
                            <option value="" >--Karachi SC--</option>
                            <option value="" >--Kohat SC--</option>
                            <option value="" >--Quetta SC--</option>
                            <option value="" >--Gujranwala SC--</option>
                        </select>
                    </div>
                    <div class="form-group ">
                        <label for="testdate" class="form-label">Test Date:</label>
                        <select class="form-select " id="testdate">
                            <option value="" >--08:00 AM--</option>
                            <option value="" >--Select Test Date--</option>
                        </select>
                    </div>
                </div>

                <div style="background-color: blue;">
                    <br>
                </div>
                <div class="form-group mb-4 mt-4">
                    <label for="ward" class="form-label">
                        Shaheed/ Naval Ward: <span style="color: red;">(Son or daughter
                            of Naval person or Naval Shaheed)</span></label>
                    <select class="form-select " id="ward">
                        <option value="" selected>Not Applicable</option>
                        <option value="">Naval Ward</option>
                        <option value="">PN Shaheed</option>
                    </select>
                </div>

            </div>
            <div>
                <h4 class="mb-4">Personal information</h4>
                <div class="container d-flex justify-content-center flex-column align-items-center">
                    <div class="upload-box">
                        <img src="#" alt="Upload Image">
                    </div>
                    <input type="file" runat="server" id="imageuploader" accept="image/jpeg, image/png"/>
                    <%--<button class="upload-button" id="uploadBtn"></button>--%>
                    <p class="resize-link">
                        To reduce your picture size to 20 kb you may use this link <a href="#">Resize
                            Picture</a>
                    </p>
                </div>

                <div class="d-flex gap2 flex-wrap mb-4">
                    <div class="form-group mb-4 d-flex flex-column">
                        <label for="c_name" class="form-label">Candidate Name:</label>
                        <input type="text" id="c_name" runat="server" class="form-control" placeholder="Candidate Name">
                    </div>
                    <div class="form-group mb-4">
                        <label for="c_cnic" class="form-label">Candidate CNIC:</label>
                        <input type="text" id="c_cnic" runat="server" class="form-control" placeholder="Candidate's CNIC">
                    </div>
                </div>
                <div class="d-flex gap2 flex-wrap mb-4">
                    <div class="form-group mb-4 d-flex flex-column">
                        <label for="f_name" class="form-label">Father Name:</label>
                        <input type="text" id="f_name" runat="server" class="form-control" placeholder="Father/Guardian Name">
                    </div>
                    <div class="form-group mb-4">
                        <label for="c_cnic" class="form-label">Father CNIC:</label>
                        <input type="text" id="f_cnic" runat="server" class="form-control" placeholder="Father/Guardian CNIC">
                    </div>
                </div>
                <div class="form-group mb-4">
                    <label for="gender" class="form-label">Gender:</label>
                    <select class="form-select" runat="server" id="gender">
                        <option value="" >--Gender--</option>
                        <option value="Female" >--Female--</option>
                        <option value="Male" >--Male--</option>
                        
                    </select>
                </div>
                <div class="form-group mb-4">
                    <label for="status" class="form-label">Marital Status:</label>
                    <select class="form-select " runat="server" id="status">
                         <option value="" >--Marital Status--</option>
                        <option value="Un Married" >Un Married</option>
                        <option value="Married" >Married</option>
                       
                    </select>
                </div>
                <div class="d-flex gap3 flex-wrap mb-4">
                    <div class="form-group " >
                        <label for="religion" class="form-label">Religion:</label>
                        <select class="form-select " runat="server" id="religion">
                            <option value="" >--Religion--</option>
                            <option value="Muslim" >Muslim</option>
                            <option value="Non Muslim" >Non Muslim</option>
                            
                        </select>
                    </div>
                   <div class="form-group">
    <label for="province" class="form-label">Province:</label>
    <select class="form-select" id="province" name="province" runat="server">
        <option value="">--Province--</option>
        <option value="Sindh">Sindh</option>
        <option value="Punjab">Punjab</option>
        <option value="KPK">KPK</option>
        <option value="Balochistan">Balochistan</option>
        <option value="Azad Kashmir">Azad Kashmir</option>
    </select>
</div>
 </div>
                <div class="form-group mb-4">
                    <label for="domicile" class="form-label">District Domicile:</label>
                    <select class="form-select" runat="server" id="domicile" name="domicile">
                        <option value="East" >East</option>
                        <option value="West" >West</option>
                        <option value="North" >North</option>
                        <option value="South" >South</option>
                        <option value="" >District</option>
                    </select>
                </div>
                <div class="form-group d-flex flex-column">
    <label for="dob">Date of birth:</label>
    <input type="date" id="dob" runat="server" class="form-control email" name="dob" placeholder="Date Of Birth">
</div>
                    <div class="form-group d-flex flex-column">
                        <label for="email">Email:</label>
                        <input type="email" id="email" runat="server" class="form-control email" name="email" placeholder="Email">
                    </div>

                </div>

                <div class="d-flex gap5 flex-wrap mb-4">
                    <div class="form-group d-flex flex-column">
                        <label for="postal-address">Postal Address:</label>
                        <textarea id="postaladdress"  name="postaladdress" runat="server" class="form-control"
                            placeholder="Postal Address"></textarea>
                    </div>

                    <div class="form-group d-flex flex-column">
                        <label for="permanent-address">Permanent Address:</label>
                        <textarea id="permanentaddress"  name="permanentaddress" runat="server" class="form-control"
                            placeholder="Permanent Address"></textarea>
                    </div>
                </div>

                <div class="d-flex gap6 flex-wrap mb-4">
                    <div class="form-group d-flex flex-column ">
                        <label for="candidate-mobile">Candidate's Mobile Number:</label>
                        <input type="tel" id="candidatemobile" name="candidatemobile" runat="server" class="form-control"
                            placeholder="i.e. 03001234567">
                    </div>

                    <div class="form-group d-flex flex-column">
                        <label for="father-mobile">Father's Mobile Number:</label>
                        <input type="tel" id="fathermobile" name="fathermobile" runat="server"  class="form-control"
                            placeholder="i.e. 03001234567" required>
                    </div>
                </div>

            

            <p class="note">
                <b>Please do not provide ported mobile number (which is converted from one network to
          another)</b>
            </p>


            <div class="form-field text-center">
                <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
            </div>
        </form>


    </div>

</body>

</html>
