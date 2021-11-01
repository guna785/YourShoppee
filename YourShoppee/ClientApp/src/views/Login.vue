<script lang="ts">
import {Vue} from 'vue-class-component';

export default class Login extends Vue {
   LoginView:any={
       userName:"",
       password:"",
       rememberMe:"yes"
   }
}
</script>
<template>
    <main class="form-signin">
  <form>
    <img class="mb-4" src="../assets/logo.png" alt="" width="72" height="57">
    <h1 class="h3 mb-3 fw-normal">Please sign in</h1>

    <div class="form-floating">
      <input type="text" v-model="LoginView.userName" class="form-control" id="floatingInput" required placeholder="User Name">
      <label for="floatingInput">User Name</label>
    </div>
    <div class="form-floating">
      <input type="password" v-model="LoginView.password" class="form-control" id="floatingPassword" required placeholder="Password">
      <label for="floatingPassword">Password</label>
    </div>

    <div class="checkbox mb-3">
      <label>
        <input type="checkbox" v-model="LoginView.rememberMe" true-value="yes" false-value="no"  required value="remember-me"> Remember me
      </label>
    </div>
    <button class="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>
    <p class="mt-5 mb-3 text-muted">&copy; 2017–2021</p>
  </form>
</main>
</template>
<style>
   

   

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