<script lang="ts">
    import { Options, Vue } from 'vue-class-component';
    import VegHeader from '@/components/Vegitables/VegHeader.vue';
    import VegContent from '@/components/Vegitables/VegContent.vue';
    @Options({
        components: {
            VegHeader,
            VegContent
        }
    })
    export default class ProductPage extends Vue {

    }
</script>
<template>
    <VegHeader/>
    <VegContent/>
</template>
<style>

</style>