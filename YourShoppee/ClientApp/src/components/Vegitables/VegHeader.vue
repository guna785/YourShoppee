<script lang="ts">
    import { Vue } from 'vue-class-component';
    export default class VegHeader extends Vue {

    }
</script>
<template>
    <!-- Header -->
    <div id="header">
        <!-- Logo -->
        <h1 id="logo"><a title="Your Shopee.Com" href="">Vegetables store</a></h1>
        <p class="contact"><a class="cont" title="Contact">0413-2271615</a></p>
        <p class="shopping-cart"><a class="cart" href="shopping cart.html" title="Your Shopping Cart">Your Cart</a></p>
        <p class="shopping-cart1"><a class="cart1" href="check out.html" title="your check out">CheckOut</a></p>
        <p class="login"><a class="log" href="log.html" title="Login / Signup">Login / Sign Up</a></p>

        <!-- Search -->
        <div class="search-expand"></div>
        <div id="search">
            <div class="retract-button">
                <p>retract</p>
            </div>
            <form action="" method="post">
                <input type="text" class="field" value="Search" title="Search" />
                <input type="submit" value="" class="submit-button" />
            </form>
        </div>

        <!-- END Search -->
        <div class="cl"></div>
        <!-- Navigation -->
        <div id="navigation">
        </div>
        <div class="cl"></div>
        <!-- END Navigation -->
        <!-- Dropdown Navigation -->
        <div id="sort-nav">
            <span class="label-left"></span>
            <div class="label-bg">
                <ul>
                    <li>
                        <a style="color: orange;" title="Home" href="home.html">Home</a>
                    </li>

                </ul>
            </div>
            <span class="label-right"></span>
        </div>
        <!-- END Dropdown Navigation -->
        <div class="cl"></div>
    </div>
    <!-- END Header -->
</template>
<style>
    #header {
        position: relative;
        padding: 5px;
        height: 150px;
        background-color: #3385FF;
        margin-top: 3px;
    }
    #logo {
        display: inline;
        float: left;
        padding: 7px 0 0 34px;
        font-size: 0;
        line-height: 0;
        width: 239px;
        margin-left: 160px;
    }

        #logo a {
            display: block;
            width: 239px;
            height: 45px;
            background: url(../../assets/VegImages/logo.png) no-repeat 0 0;
            text-indent: -4000px;
        }

    #search {
        position: absolute;
        display: none;
        top: 1px;
        right: 6px;
        padding-right: 3px;
        width: 210px;
        background: url(../../assets/VegImages/search.png) no-repeat 0 0;
    }

        #search .field {
            display: inline;
            float: left;
            padding: 5px 15px 4px;
            width: 99px;
            background: none;
            border: 0;
        }

        #search .submit-button {
            display: inline;
            float: right;
            padding: 2px 0 8px;
            width: 38px;
            border: 0;
            background: 0;
            cursor: pointer;
        }

        #search .retract-button {
            font-size: 0;
            line-height: 0;
            text-indent: -4000px;
            display: block;
            float: left;
            padding-left: 20px;
            width: 15px;
            height: 30px;
            background: url(../../assets/VegImages/retract-button.png) no-repeat 50% 50%;
            cursor: pointer;
        }

    .search-expand {
        position: relative;
        top: 1px;
        right: 5px;
        width: 58px;
        height: 30px;
        cursor: pointer;
        background: url(../../assets/VegImages/search-expand.png) no-repeat 0 0;
        float: right;
        margin-top: -4px;
    }


    #search1 {
        position: absolute;
        display: none;
        top: 1px;
        right: 6px;
        padding-right: 3px;
        width: 210px;
        background: url(../../assets/VegImages/search.png) no-repeat 0 0;
    }

        #search1 .field1 {
            display: inline;
            float: left;
            padding: 5px 15px 4px;
            width: 99px;
            background: none;
            border: 0;
        }

        #search1 .submit-button1 {
            display: inline;
            float: right;
            padding: 2px 0 8px;
            width: 38px;
            border: 0;
            background: 0;
            cursor: pointer;
        }

        #search1 .retract-button1 {
            font-size: 0;
            line-height: 0;
            text-indent: -4000px;
            display: block;
            float: left;
            padding-left: 20px;
            width: 15px;
            height: 30px;
            background: url(../../assets/VegImages/retract-button.png) no-repeat 50% 50%;
            cursor: pointer;
        }

    .search-expand1 {
        position: relative;
        top: 1px;
        right: 5px;
        width: 58px;
        height: 30px;
        cursor: pointer;
        background: url(../../assets/VegImages/search-expand.png) no-repeat 0 0;
        float: right;
        margin-top: -44px;
    }



    .shopping-cart {
        text-align: right;
        padding-right: 77px;
        color: #8be3fe;
        font-family: Trebuchet MS, arial, helvetica, sans-serif;
        font-weight: bold;
    }

        .shopping-cart span {
            padding-left: 17px;
            color: #fff;
            font-weight: normal;
            font-size: 15px;
        }

        .shopping-cart a {
            color: #fff;
            padding-left: 17px;
            font-size: 15px;
        }

            .shopping-cart a.cart {
                background: url(../../assets/VegImages/1.png) no-repeat 0 50%;
                padding-left: 23px;
                float: left;
                margin-left: 20px;
                margin-top: 5px;
            }

            .shopping-cart a:hover {
                text-decoration: none;
                color: orange;
            }

    .shopping-cart1 {
        text-align: right;
        padding-right: 77px;
        color: #8be3fe;
        font-family: Trebuchet MS, arial, helvetica, sans-serif;
        font-weight: bold;
    }

        .shopping-cart1 a.cart1 {
            background: url(../../assets/VegImages/221.png) no-repeat 0 50%;
            padding-left: 23px;
            float: left;
            margin-left: 20px;
            margin-top: 5px;
        }

        .shopping-cart1 a {
            color: #fff;
            padding-left: 17px;
            font-size: 15px;
        }

            .shopping-cart1 a:hover {
                text-decoration: none;
                color: orange;
            }
    .home a {
        color: white;
        font-weight: bold;
        font-size: 15px;
        margin-top: 5px;
        float: left;
        margin-left: 300px;
    }

     

        .home a:hover {
            text-decoration: none;
            color: orange;
        }


    .contact a {
        color: white;
        font-weight: bold;
        font-size: 15px;
        margin-top: 5px;
        float: left;
        margin-left: 300px;
    }

        .contact a.cont {
            background: url(../../assets/VegImages/12.png) no-repeat 0 50%;
            padding-left: 23px;
        }

        .contact a:hover {
            text-decoration: none;
            color: orange;
        }


    .contact1 a {
        font-weight: bold;
        font-size: 15px;
        margin-top: 5px;
        float: left;
        margin-left: 20px;
        color: white;
    }

        .contact1 a:hover {
            text-decoration: none;
            color: orange;
        }

    .login a {
        color: white;
        font-weight: bold;
        font-size: 15px;
        float: left;
        margin-top: 5px;
        margin-left: 30px;
    }

    .login a {
        background: url(../../assets/VegImages/sig2.png) no-repeat 0 50%;
        padding-left: 23px;
    }

        .login a:hover {
            text-decoration: none;
            color: orange;
        }
    /*------------------------------------------------------*/
    .login1 ul li a {
        color: white;
        font-weight: bold;
        font-size: 15px;
        float: left;
    }

    .login1 ul li {
        background: url(../../assets/VegImages/sig2.png) no-repeat 0 50%;
        padding-left: 23px;
    }

        .login1,
        .login1 ul,
        .login1 ul li,
        .login1 ul li a,
        .login1 #menu-button {
            margin-top: 2px;
            margin-left: 30px;
            padding: 0;
            border: 0;
            list-style: none;
            line-height: 1;
            display: block;
            position: relative;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
        }

            .login1:after,
            .login1 > ul:after {
                content: ".";
                display: block;
                clear: both;
                visibility: hidden;
                line-height: 0;
                height: 0;
            }

            .login1 #menu-button {
                display: none;
            }
            /*.login {
  font-family: 'Open Sans', Helvetica, sans-serif;
  background: -moz-linear-gradient(top, #51bbd2 0%, #2d97af 100%);
  background: -webkit-gradient(linear, left top, left bottom, color-stop(0%, #51bbd2), color-stop(100%, #2d97af));
  background: -webkit-linear-gradient(top, #51bbd2 0%, #2d97af 100%);
  background: -o-linear-gradient(top, #51bbd2 0%, #2d97af 100%);
  background: -ms-linear-gradient(top, #51bbd2 0%, #2d97af 100%);
  background: linear-gradient(to bottom, #51bbd2 0%, #2d97af 100%);
}*/
            /*.login > ul {
  box-shadow: inset 0 -3px 0 rgba(0, 0, 0, 0.05);
}*/
            .login1.align-right > ul > li {
                float: right;
            }

            .login1 > ul > li {
                float: left;
                display: inline-block;
            }

            .login1.align-center > ul {
                float: none;
                text-align: center;
            }

                .login1.align-center > ul > li {
                    float: none;
                }

            .login1.align-center ul ul {
                text-align: left;
            }

            .login1 > ul > li > a {
                text-decoration: none;
                font-size: 15px;
                font-weight: 700;
                letter-spacing: 1px;
            }
            /*.login > ul > li:hover > a,
.login > ul > li > a:hover,
.login > ul > li.active > a {
  color: #ffffff;
  background: #32a9c3;
  background: rgba(0, 0, 0, 0.1);
}*/
            .login1 > ul > li.has-sub > a {
                padding-right: 45px;
            }

                .login1 > ul > li.has-sub > a::after {
                    content: "";
                    position: absolute;
                    width: 0;
                    height: 0;
                    border: 6px solid transparent;
                    border-top-color: #d3eced;
                    left: 43px;
                    top: 5px;
                }

            .login1 > ul > li.has-sub.active > a::after,
            .login1 > ul > li.has-sub:hover > a {
                border-top-color: #ffffff;
            }

            .login1 ul ul {
                position: absolute;
                left: -9999px;
                top: 0px;
                padding-top: 6px;
                font-size: 15px;
                opacity: 0;
                -webkit-transition: top 0.2s ease, opacity 0.2s ease-in;
                -moz-transition: top 0.2s ease, opacity 0.2s ease-in;
                -ms-transition: top 0.2s ease, opacity 0.2s ease-in;
                -o-transition: top 0.2s ease, opacity 0.2s ease-in;
                transition: top 0.2s ease, opacity 0.2s ease-in;
            }

            .login1.align-right ul ul {
                text-align: right;
            }

            .login1 > ul > li > ul::after {
                content: "";
                position: absolute;
                width: 0;
                height: 0;
                border: 5px solid transparent;
                border-bottom-color: #ffffff;
                top: -0px;
                left: 75px;
            }
            /*
.login.align-right > ul > li > ul::after {
  left: auto;
  right: 20px;
}*/
            /*.login ul ul ul::after {
  content: "";
  position: absolute;
  width: 0;
  height: 0;
  border: 5px solid transparent;
  border-right-color: #ffffff;
  top: 11px;
  left: -4px;
}
.login.align-right ul ul ul::after {
  border-right-color: transparent;
  border-left-color: #ffffff;
  left: auto;
  right: -4px;
}*/
            .login1 > ul > li > ul {
                top: 120px;
            }

            .login1 > ul > li:hover > ul {
                top: 30px;
                left: -70px;
                opacity: 1;
            }
            /*
.login.align-right > ul > li:hover > ul {
  left: auto;
  right: 0;
}*/
            .login1 ul ul ul {
                padding-top: 0;
                padding-left: 6px;
            }

            .login1.align-right ul ul ul {
                padding-right: 6px;
            }

            .login1 ul ul > li:hover > ul {
                left: 0px;
                top: 0;
                opacity: 1;
            }

            .login1.align-right ul ul > li:hover > ul {
                left: auto;
                opacity: 1;
            }

            .login1 ul ul li a {
                text-decoration: none;
                font-weight: 400;
                padding: 11px 25px;
                width: 150px;
                color: #777777;
                background: #ffffff;
                box-shadow: 0 2px 2px rgba(0, 0, 0, 0.1), 1px 1px 1px rgba(0, 0, 0, 0.1), -1px 1px 1px rgba(0, 0, 0, 0.1);
            }

            .login1 ul ul li:hover > a,
            .login1 ul ul li.active > a {
                color: #333333;
            }

            .login1 ul ul li:first-child > a {
                border-top-left-radius: 3px;
                border-top-right-radius: 3px;
            }

            .login1 ul ul li:last-child > a {
                border-bottom-left-radius: 3px;
                border-bottom-right-radius: 3px;
            }

            .login1 > ul > li > ul::after {
                position: absolute;
                display: block;
            }

            .login1 ul ul li.has-sub > a::after {
                content: "";
                position: absolute;
                width: 0;
                height: 0;
                border-left-color: #777777;
                right: 17px;
                top: 14px;
            }

            .login1.align-right ul ul li.has-sub > a::after {
                right: auto;
                left: 17px;
            }
    /*.login ul ul li.has-sub.active > a::after,
.login ul ul li.has-sub:hover > a::after {
  border-left-color: #333333;
}
.login.align-right ul ul li.has-sub.active > a::after,
.login.align-right ul ul li.has-sub:hover > a::after {
  border-right-color: #333333;
  border-left-color: transparent;
}*/
    span.label-left {
        display: block;
        float: left;
        width: 21px;
        height: 42px;
        background: url(../../assets/VegImages/label-left.png) no-repeat 0 0;
        margin-left: 175px;
    }

    span.label-right {
        display: block;
        float: left;
        width: 32px;
        height: 42px;
        background: url(../../assets/VegImages/label-right.png) no-repeat 0 0;
    }

    .label-bg {
        display: inline;
        float: left;
        height: 42px;
        background: url(../../assets/VegImages/label-bg.png) repeat-x 0 0;
    }

    .label {
        position: absolute;
        top: -15px;
        left: -7px;
        height: 42px;
        width: 203px;
        background: url(../../assets/VegImages/label.png) no-repeat 0 0;
    }

        .label h3 {
            padding-left: 15px;
            display: inline;
            float: left;
            font-family: Arial, helvetica, sans-serif;
            font-size: 18px;
            color: #fff;
            font-weight: normal;
            line-height: 30px;
        }

    #sign1 {
        position: absolute;
        top: 580px;
        left: 137px;
        height: 42px;
        width: 203px;
        background: url(../../assets/VegImages/label.png) no-repeat 0 0;
    }

        #sign1 h3 {
            padding-left: 15px;
            display: inline;
            float: left;
            font-family: Arial, helvetica, sans-serif;
            font-size: 18px;
            color: #fff;
            font-weight: normal;
            line-height: 30px;
        }

    #sign2 {
        position: absolute;
        top: 580px;
        left: 687px;
        height: 42px;
        width: 203px;
        background: url(../../assets/VegImages/label.png) no-repeat 0 0;
    }

        #sign2 h3 {
            padding-left: 15px;
            display: inline;
            float: left;
            font-family: Arial, helvetica, sans-serif;
            font-size: 18px;
            color: #fff;
            font-weight: normal;
            line-height: 30px;
        }

    #sign3 {
        position: absolute;
        top: 580px;
        left: 407px;
        height: 42px;
        width: 203px;
        background: url(../../assets/VegImages/label.png) no-repeat 0 0;
    }

        #sign3 h3 {
            padding-left: 15px;
            display: inline;
            float: left;
            font-family: Arial, helvetica, sans-serif;
            font-size: 18px;
            color: #fff;
            font-weight: normal;
            line-height: 30px;
        }


    #navigation {
        display: inline;
        float: right;
        padding: 10px 32px 0 0;
    }

        #navigation ul li {
            list-style: none;
            display: inline;
            float: left;
            font-weight: bold;
            line-height: 14px;
            padding-left: 30px;
        }

            #navigation ul li a {
                color: #fff;
                font-size: 20px;
            }

                #navigation ul li a:hover {
                    color: #005388;
                    text-decoration: none;
                }

    #sort-nav {
        display: inline;
        position: absolute;
        top: 73px;
        left: 0;
        height: 42px;
        z-index: 50;
    }

        #sort-nav ul {
            display: inline;
            float: left;
            padding-left: 13px;
            list-style: none;
            height: 42px;
        }

            #sort-nav ul li {
                position: relative;
                display: inline;
                float: left;
                line-height: 32px;
                padding-right: 44px;
            }

                #sort-nav ul li.last {
                    padding-right: 19px;
                }

                #sort-nav ul li a {
                    position: relative;
                    padding-right: 12px;
                    font-weight: bold;
                    color: #fff; /*background: url(images/nav-item.png) no-repeat right 50%;*/
                    font-size: 18px;
                    margin-left: 20px;
                }

        #sort-nav .dd {
            display: none;
            position: absolute;
            z-index: 100;
            top: 30px;
            left: 0;
            width: 109px;
            background: #3a8cc0;
        }

            #sort-nav .dd ul {
                float: none;
            }

                #sort-nav .dd ul li {
                    float: left;
                    background: none;
                    padding: 0;
                    width: 109px;
                }

                    #sort-nav .dd ul li a {
                        display: block;
                        padding: 0 0 0 15px;
                        line-height: 25px;
                        width: 95px;
                        background: none;
                    }

        #sort-nav ul li a:hover {
            text-decoration: none;
            color: orange;
        }
</style>