import {Commit, createStore } from 'vuex'

const store = createStore({
    state: {
        authenticated:false,        
    },
    mutations: {
        SET_AUTH:(state:{authenticated:boolean},auth:boolean)=>state.authenticated=auth
    },
    actions: {
        setAuth:({commit}:{commit:Commit},auth:boolean)=>commit('SET_AUTH',auth)
    },
    modules: {
    }
});
export default store;
