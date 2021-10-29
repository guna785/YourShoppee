<script lang="ts">
    import { Options, Vue } from 'vue-class-component';
    import VegHeader from '@/components/Vegitables/VegHeader.vue';
    @Options({
        components: {
            VegHeader
        }
    })
    export default class Vegitables extends Vue {

    }
</script>
<template>
    <VegHeader/>
</template>
<style>

</style>