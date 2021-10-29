<script lang="ts">
    import { Vue } from 'vue-class-component';
    export default class LandingFooter extends Vue {

    }
</script>
<template>
    <div class="footer-top"></div>
    <div class="footer" />
</template>
<style>
    .footer-top{
        height:60px;
        width:100%;
    }
    .footer {
        width: 100%;
        height: 60px;
        position:fixed;
        bottom:0;
        border-top: 1px solid black;
        background: url(../../assets/images/content.gif) center bottom repeat;
    }
</style>