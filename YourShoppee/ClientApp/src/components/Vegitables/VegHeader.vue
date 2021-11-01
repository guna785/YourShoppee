<script lang="ts">
    import { Vue } from 'vue-class-component';
    export default class VegHeader extends Vue {
        
    }
</script>
<template>
    <div class="header">
        <div class="container">
            <div class="container-fluid navbarcss">
                <a title="Your Shopee.Com">
                    <div id="logo">
                       <img width="30" height="30"  style="background-color: white; border-radius: 50%;" alt="logo" src="../../assets/logo.png"/>
                        <p style="color:white;font-size:22px;">VEGITABLE <span style="color:yellow;font-size:12px;">Stores</span></p>
                    </div>
                </a>

                <a class="active" title="Contact" href="#"><p class="contact"><img src="../../assets/VegImages/12.png" />   0413-2271615</p></a>
                <a href="#" title="Your Shopping Cart"><p class="shopping-cart"><img src="../../assets/VegImages/1.png" />  Your Cart <span></span></p></a>

                <a href="#" title="Login / Signup"><p class="login"><img src="../../assets/VegImages/sig2.png" />  Login / Sign Up</p></a>
            </div>
            
            <div style="margin-top: 30px; " class="col-md-12">
                <div class="card card-search">
                    <div class="Searchbar">
                        <div class="row" >
                            <div class="imgflex">
                                <img style="height:120px;width:150px;" src="../../assets/VegImages/vegg1.png" />
                                <img style="height:120px;width:150px;" src="../../assets/VegImages/vegg2.png" />
                                <img style="height:120px;width:150px;" src="../../assets/VegImages/vegg3.png" />
                                <img style="height:120px;width:150px;" src="../../assets/VegImages/vegg4.png" />
                                <img style="height:120px;width:150px;" src="../../assets/VegImages/vegg5.png" />
                            </div>
                        </div>
                        <div class="row height d-flex justify-content-center align-items-center">
                            <div class="col-md-8">
                                <div class="search"> <i class="fa fa-search"></i> <input type="text" class="form-control" placeholder="Have a question? Ask Now"> <button class="btn" style="background-color:orange; color:white;">Search</button> </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</template>
<style>
    .card-search {
        height: 200px;
        background: url('../../assets/VegImages/products-middle.png');
        background-repeat: no-repeat;
        background-position: center center;
        background-size: cover;
    }
    .header {
        width: 100%;
        padding: 5px;
        height: 150px;
        background-color: #3385FF;
        margin-top: 3px;
    }


    #logo {
        margin-top:-50px;
        display: block;
        width: 239px;
        padding:20px;
        height: 45px;
    }

    .navbarcss {
        width: 100%;
        float: left;
        display: flex;
        justify-content: left;
    }

        .navbarcss a {
            float: left;
            padding: 12px;
            color: white;
            text-decoration: none;
            font-size: 17px;
        }

    .contact {
        color: white;
        font-weight: bold;
        font-size: 15px;
        float: left;
    }

        .contact:hover {
            text-decoration: none;
            color: orange;
        }

    .shopping-cart {
        text-align: right;
        color: white;
        font-family: Trebuchet MS, arial, helvetica, sans-serif;
        font-weight: bold;
    }

        .shopping-cart span {
            padding-left: 8px;
            color: #fff;
            font-weight: normal;
            font-size: 15px;
        }


        .shopping-cart:hover {
            text-decoration: none;
            color: orange;
        }

    .login {
        color: white;
        font-weight: bold;
        font-size: 15px;
        float: left;
    }


        .login:hover {
            text-decoration: none;
            color: orange;
        }

    .Searchbar{
        text-align:center;
        margin:20px;
    }
    .search {
        position: relative;
        box-shadow: 0 0 40px rgba(51, 51, 51, .1)
    }

        .search input {
            height: 60px;
            text-indent: 25px;
            border: 2px solid #d6d4d4
        }

            .search input:focus {
                box-shadow: none;
                border: 2px solid blue
            }

        .search .fa-search {
            position: absolute;
            top: 20px;
            left: 16px
        }

        .search button {
            position: absolute;
            top: 5px;
            right: 5px;
            height: 50px;
            width: 110px;
            background: blue
        }
    .imgflex {
        max-width: 100px;
        margin: 10px;
        display:flex;
        justify-content:center;
        padding:10px;
        border:medium;
    }
    @media screen and (max-width: 500px) {
        .navbarcss a {
            float: none;
            display: block;
        }
    }


</style>