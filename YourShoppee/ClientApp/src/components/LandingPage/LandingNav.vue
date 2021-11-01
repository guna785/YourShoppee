<script lang="ts">
    import { Vue } from 'vue-class-component';
    import {useStore} from 'vuex';
    export default class LandingNav extends Vue {
        store:any=useStore();
        get isAuthenticated(){
            return !this.store.state.authenticated;
        }
    }
</script>
<template>
    <header class="codrops-top">
        <a href="#">
            <strong>&laquo; Menu: </strong>Home
        </a>
        <span class="right">
             <router-link v-if="isAuthenticated" to="/Login">Sign In / Sign Up</router-link>
             
           <router-link to="/">
                <strong>About Us</strong>
           </router-link>
        </span>
        <div class="clr"></div>
    </header>
    <header class="shopping-header">
        <h1>Your Shoppee <span>.COM</span></h1>
    </header>
</template>
<style>
    .shopping-header {
        padding: 10px 20px 10px 20px;
        margin-bottom: 0px;
        position: relative;
        display: block;
        text-align: center;
        width: 100%;
    }

        .shopping-header h1 {
            font-family: "BebasNeueRegular", Arial, sans-serif;
            font-size: 55px;
            position: relative;
            font-weight: 300;
            text-transform: uppercase;
            color: rgba(101,141,114,0.9);
            text-shadow: 1px 1px 1px rgba(0,0,0,0.2);
            padding: 0px 0px 5px 0px;
        }

            .shopping-header h1 span {
                color: #a0caad;
                text-shadow: 1px 1px 1px rgba(255,255,255,0.4);
                font-size: 20px;
            }

    .codrops-top {
        line-height: 24px;
        font-size: 20px;
        text-transform: uppercase;
        z-index: 9999;
        position: relative;
        box-shadow: 1px 0px 2px rgba(0,0,0,0.2);
        -webkit-animation: slideOut 0.5s ease-in-out 0.3s backwards;
        min-height: 70px;
        border-bottom: 1px solid black;
        width: 100%;
        background: url(../../assets/content.gif) center bottom repeat;
    }

        .codrops-top a {
            padding: 0px 10px;
            letter-spacing: 1px;
            color: #333;
            text-shadow: 0px 1px 1px #fff;
            display: block;
            float: left;
            margin-top: 10px;
        }

            .codrops-top a:hover {
                background: #fff;
            }

        .codrops-top span.right {
            float: right;
            margin-right: 100px;
        }

            .codrops-top span.right a {
                float: left;
                display: block;
            }

        .codrops-top a {
            margin-left: 20px;
        }
</style>