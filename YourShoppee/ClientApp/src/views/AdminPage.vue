<script lang="ts">
    import {Options, Vue } from 'vue-class-component';
    import AdminNav from '@/components/Admin/AdminNav.vue';
    import Dashboard from '@/components/Admin/Dashboard.vue';
    import {useStore} from 'vuex';
    @Options({
        components:{
            AdminNav,
            Dashboard
        }
    })
    export default class AdminPage extends Vue {
        store:any=useStore();
        get isAuthenticated(){
            return this.store.state.authenticated;
        }
        mounted(){
            if(!this.isAuthenticated){
                localStorage.clear();
                this.$router.push('/Login');
            }          
        }
    }
</script>
<template>
    <AdminNav/>
    <Dashboard/>
</template>
<style>
   :root {
        --offcanvas-width: 270px;
        --top-navbar-height: 56px;
    }

    .sidebar-nav {
        width: var(--offcanvas-width) !important;
        top: 0;
        left: 0;
        top: var(--top-navbar-height) !important;
        height: calc(100%-var(--top-navbar-height)) !important;
    }
      .sidebar-link {
            display: flex !important;
            align-items: center !important;
        }

            .sidebar-link .right-icon {
                display: inline-flex !important;
                transition: all ease 0.25s;
            }

            .sidebar-link [aria-expanded=true] .right-icon {
                transform: rotate(180deg) !important;
            }
    @media screen and (min-width: 992px) {
        body {
            overflow: auto;
        }
        main{
            margin-left: var(--offcanvas-width) !important;
        }
        .offcanvas-backdrop::before {
            display: none;
        }

        .sidebar-nav {
            transform: none !important;
            visibility: visible !important;
            top: var(--top-navbar-height) !important;
            height: calc(100%-var(--top-navbar-height)) !important;
        }

       
    }
</style>