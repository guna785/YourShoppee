<script lang="ts">
    import { Vue } from 'vue-class-component';
    export default class Slider extends Vue {

    }
 </script>
<template>
    <section id="dg-container" class="dg-container">
        <div class="dg-wrapper">
            <a href="#"><img src="../../assets/images/slid6.jpg" class="img-fluid" alt="image01"></a>
            <a href="#"><img src="../../assets/images/slid7.jpg" class="img-fluid" alt="image02"></a>
            <a href="#"><img src="../../assets/images/slid8.jpg" class="img-fluid" alt="image03"></a>
            <a href="#"><img src="../../assets/images/slider4.jpg" class="img-fluid" alt="image04"></a>
            <a href="#"><img src="../../assets/images/slider3.jpg" class="img-fluid" alt="image05"></a>

        </div>
        <!--nav>
            <span class="dg-prev">&lt;</span>
            <span class="dg-next">&gt;</span>
        </nav-->
    </section>
</template>
<style>
    .dg-container {
        width: 100%;
        height: 350px;
        position: relative;
        border-bottom: 1px solid black;
        border-top: 1px solid black;
        background-color: white;
        margin-left: auto;
        margin-right: auto;
        display: flex;
        justify-content: center;
    }

    .dg-wrapper {
        width: 381px;
        height: 216px;
        margin: 0 auto;
        position: relative;
        -webkit-transform-style: preserve-3d;
        -moz-transform-style: preserve-3d;
        -o-transform-style: preserve-3d;
        -ms-transform-style: preserve-3d;
        transform-style: preserve-3d;
        -webkit-perspective: 1000px;
        -moz-perspective: 1000px;
        -o-perspective: 1000px;
        -ms-perspective: 1000px;
        perspective: 1000px;
        padding: 10px;
    }

        .dg-wrapper a {
            width: 600px;
            height: 300px;
            display: block;
            margin-left: auto;
            margin-right: auto;
            position: absolute;
            box-shadow: 0px 10px 20px rgba(0,0,0,0.3);
        }

            .dg-wrapper a.dg-transition {
                -webkit-transition: all 0.5s ease-in-out;
                -moz-transition: all 0.5s ease-in-out;
                -o-transition: all 0.5s ease-in-out;
                -ms-transition: all 0.5s ease-in-out;
                transition: all 0.5s ease-in-out;
            }

            .dg-wrapper a img {
                display: block;
                padding: 0px 0px 0px 1px;
                width: 600px;
                height: 300px;
                border: 1px solid black;
            }
    
</style>