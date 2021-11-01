<template> 
  <router-view/>
</template>
<script lang="ts">
    import { Vue } from 'vue-class-component';
    
    export default class App extends Vue {

    }
</script>
<style>
    @font-face {
        font-family: 'BebasNeueRegular';
        src: url('./assets/fonts/BebasNeue-webfont.eot');
        src: url('./assets/fonts/BebasNeue-webfont.eot?#iefix') format('embedded-opentype'), url('./assets/fonts/BebasNeue-webfont.woff') format('woff'), url('./assets/fonts/BebasNeue-webfont.ttf') format('truetype'), url('./assets/fonts/BebasNeue-webfont.svg#BebasNeueRegular') format('svg');
        font-weight: normal;
        font-style: normal;
    }
</style>
