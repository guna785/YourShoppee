<script lang="ts">
    import { Options, Vue } from 'vue-class-component';
    import LandingNav from '@/components/LandingPage/LandingNav.vue';
    import Slider from '@/components/LandingPage/Slider.vue';
    import LandingFooter from '@/components/LandingPage/LandingFooter.vue';
    import LandingContent from '@/components/LandingPage/LandingContent.vue';
    @Options({
        components: {
            LandingNav,
            Slider,
            LandingFooter,
            LandingContent
        }
    })
    export default class LandingPage extends Vue{

    }
</script>

<template>
    <LandingNav />
    <div class="landing-container">
        <LandingContent />
        <LandingFooter/>
    </div>
    
</template>
<style>
    .landing-container {
        width: 100%;
        text-align: center;
    }
</style>