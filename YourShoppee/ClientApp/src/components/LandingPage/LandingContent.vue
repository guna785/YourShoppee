<script lang="ts">
    import { Vue } from 'vue-class-component';
    export default class LandingContent extends Vue {

    }
</script>
<template>
    <div class="body-content">
        <div class="content-wrapper">
            <div class="cont1">
                <img class="image2" src="../../assets/images/find3.png" />

                <div class="container-a1">
                    <ul class="caption-style-1">
                        <li>
                            <img class="prod" src="../../assets/images/vegg.jpg" alt="" style="width: 200px; height: 200px;" />
                            <div class="caption">
                                <div class="blur"></div>
                                <div class="caption-text">
                                    <a class="com1" href="veg/home.html"><h1>Shop Now</h1></a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <img class="image3" src="../../assets/images/vege1.png" />
                    <ul class="caption-style-1">
                        <li>
                            <img class="prod" src="../../assets/images/dress.jpg" alt="" style="width: 200px; height: 200px;" />
                            <div class="caption">
                                <div class="blur"></div>
                                <div class="caption-text">
                                    <a class="com1" href="dress/home.html"><h1>Shop Now</h1></a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <img class="image4" src="../../assets/images/dres1.png" />
                    <ul class="caption-style-1">
                        <li>
                            <img class="prod" src="../../assets/images/natural.jpg" alt="" style="width: 200px; height: 200px;" />
                            <div class="caption">
                                <div class="blur"></div>
                                <div class="caption-text">
                                    <a class="com1" href="natural/home.html"><h1>Shop Now</h1></a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <img class="image5" src="../../assets/images/home.png" />
                </div>
            </div>
        </div>

    </div>
</template>
<style>
    .body-content {
        float: left;
        /*background:url(images/content.gif) center bottom repeat;*/
        padding-bottom: 20px;
        width: 100%;
        background-color: white;
    }

    <!--
    ------------------content------------------- >

    .content-wrapper {
        float: left;
        
    }

    .cont1 {
        border-top: 1px solid black;
        margin-top: 60px;
        width: 100%;
        text-align: center;
    }

    .image2 {
        width: 350px;
        height: 40px;
        display: block;
        margin-left: auto;
        margin-right: auto;
        border-left: 3px solid black;
        border-right: 3px solid black;
        margin-top: -20px;
        background-color: white;
    }

    .com1 h1 {
        padding: 3px;
        border: 2px solid white;
        width: 110px;
        margin-left: 45px;
        color: white;
        text-decoration: none;
        cursor: pointer;
        border-radius: 5px;
    }

    a {
        text-decoration: none;
    }

    .com1 h1:hover {
        text-decoration: none;
        color: orange;
    }

    .container-a1 {
        text-align: center;
        margin-left: auto;
        margin-right: auto;
        display: flex;
        justify-content: center;
    }

    .caption-style-1 {
        list-style-type: none;
        margin: 0px;
        padding: 30px;
        float: left;
        
        
    }

        .caption-style-1 li {
            float: left;
            padding: 0px;
            position: relative;
            overflow: hidden;
            margin-top: 50px;
            margin-left: 20px;
            border-left: 5px solid gray;
            border-right: 5px solid gray;
            border-top: 1px solid gray;
            border-bottom: 1px solid gray;
            border-radius: 10px;
        }

            .caption-style-1 li:hover .caption {
                opacity: 1;
            }

            .caption-style-1 li:hover .prod {
                opacity: 1;
                transform: scale(1.15,1.15);
                -webkit-transform: scale(1.15,1.15);
                -moz-transform: scale(1.15,1.15);
                -ms-transform: scale(1.15,1.15);
                -o-transform: scale(1.15,1.15);
            }


        .caption-style-1 .prod {
            margin: 0px;
            padding: 5px;
            float: left;
            z-index: 4;
            background-color: white;
        }


        .caption-style-1 .caption {
            position: absolute;
            opacity: 0;
            -webkit-transition: all 0.45s ease-in-out;
            -moz-transition: all 0.45s ease-in-out;
            -o-transition: all 0.45s ease-in-out;
            -ms-transition: all 0.45s ease-in-out;
            transition: all 0.45s ease-in-out;
        }

        .caption-style-1 .prod {
            -webkit-transition: all 0.25s ease-in-out;
            -moz-transition: all 0.25s ease-in-out;
            -o-transition: all 0.25s ease-in-out;
            -ms-transition: all 0.25s ease-in-out;
            transition: all 0.25s ease-in-out;
        }

        .caption-style-1 .blur {
            background-color: rgba(0,0,0,0.5);
            height: 200px;
            width: 200px;
            z-index: 5;
            position: absolute;
            padding: 5px;
        }

        .caption-style-1 .caption-text h1 {
            text-transform: uppercase;
            font-size: 18px;
        }

        .caption-style-1 .caption-text {
            z-index: 10;
            color: #fff;
            position: absolute;
            width: 200px;
            height: 200px;
            text-align: center;
            top: 90px;
        }

    .image3 {
        float: left;
        position: relative;
        margin-left: -190px;
        margin-top: 280px;
        width: 130px;
        height: 30px;
    }

    .image4 {
        float: left;
        position: relative;
        margin-left: -190px;
        margin-top: 280px;
        width: 120px;
        height: 25px;
    }

    .image5 {
        float: left;
        position: relative;
        margin-left: -190px;
        margin-top: 280px;
        width: 150px;
        height: 25px;
    }
</style>