import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import store from './store';

// Optional, since every component import their Bootstrap funcionality
// the following line is not necessary
import 'bootstrap';
import 'bootstrap-icons/font/bootstrap-icons.css';
import 'bootstrap/dist/css/bootstrap.css';


createApp(App).use(store).use(router).mount('#app')
