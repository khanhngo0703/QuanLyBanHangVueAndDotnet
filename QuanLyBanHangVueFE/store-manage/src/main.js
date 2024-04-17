import { createApp } from 'vue'
import App from './App.vue'
import router from './router';
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import Select2 from 'vue3-select2-component';

var app = createApp(App);
app.use(router);
app.component("Select2", Select2);
app.mount('#app');
