<script lang="ts">
import {Vue} from 'vue-class-component';
import {useStore} from 'vuex';
import DataService from '@/Services/DataService';
import {useRouter} from 'vue-router';
export default class Login extends Vue {
  store:any = useStore();
  router:any=useRouter();
  dataService:DataService=new DataService();
   LoginView:any={
       uname:"",
       password:"",
       RememberMe:false
   };
   submit=async ()=> {
       var res=await this.dataService.Authticate(this.LoginView);
       console.log(res);
       if(res.status==200){
          localStorage.setItem("jwt",res.data.data.token.jwt);
          localStorage.setItem("refreshToken",res.data.data.token.refreshToken);
          localStorage.setItem("userName",res.data.data.uname);
          localStorage.setItem("Name",res.data.data.name);
          localStorage.setItem("role",res.data.data.role);    

          this.store.dispatch("setAuth",true);
          if(res.data.data.role==="Admin") {this.router.push("/Admin");}
          else{ this.router.push("/");}
       }
       else{
         alert("Failed");
       }
      
   }
}
</script>
<template>
    <div class="form-signin">
  <form @submit.prevent="submit">
    <img class="mb-4" src="../assets/logo.png" alt="" width="72" height="57">
    <h1 class="h3 mb-3 fw-normal">Please sign in</h1>

    <div class="form-floating">
      <input type="text" v-model="LoginView.uname" class="form-control" id="floatingInput" required placeholder="User Name">
      <label for="floatingInput">User Name</label>
    </div>
    <div class="form-floating">
      <input type="password" v-model="LoginView.password" class="form-control" id="floatingPassword" required placeholder="Password">
      <label for="floatingPassword">Password</label>
    </div>

    <div class="checkbox mb-3">
      <label>
        <input type="checkbox" v-model="LoginView.RememberMe"   value="remember-me"> Remember me
      </label>
    </div>
    <button class="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>
    <p class="mt-5 mb-3 text-muted">&copy; 2017–2021</p>
  </form>
</div>
</template>
<style>
   

    .form-signin {
        width: 100%;
        max-width: 330px;
        padding: 15px;
        margin-left: auto;
        margin-right: auto;
    }

        .form-signin .checkbox {
            font-weight: 400;
        }

        .form-signin .form-floating:focus-within {
            z-index: 2;
        }

        .form-signin input[type="text"] {
            margin-bottom: -1px;
            border-bottom-right-radius: 0;
            border-bottom-left-radius: 0;
        }

        .form-signin input[type="password"] {
            margin-bottom: 10px;
            border-top-left-radius: 0;
            border-top-right-radius: 0;
        }
</style>