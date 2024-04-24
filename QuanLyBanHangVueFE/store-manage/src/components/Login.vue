<template>
    <div class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header">
                                        <h3 class="text-center font-weight-light my-4">Login</h3>
                                    </div>
                                    <div class="card-body">
                                        <form @submit.prevent="login">
                                            <div class="form-floating mb-3">
                                                <input class="form-control" type="text" id="loginUsername"
                                                    v-model="loginForm.username" placeholder="UserName" required />
                                                <label for="inputUsername">Username</label>
                                            </div>
                                            <div class="form-floating mb-3">
                                                <input class="form-control" type="password" id="loginPassword"
                                                    v-model="loginForm.password" placeholder="Password" required />
                                                <label for="inputPassword">Password</label>
                                            </div>
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <router-link class="small" to="/forgotpassword">Forgot
                                                    Password?</router-link>
                                                <button type="submit" class="btn btn-primary">Login</button>
                                            </div>
                                            <!-- Hiển thị thông báo khi đăng nhập không thành công -->
                                            <div v-if="error" class="alert alert-danger mt-3" role="alert">
                                                {{ error }}
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><router-link to="/register">Need an account? Sign
                                                up!</router-link></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'Login_Register',
    props: {
        msg: String
    },
    data() {
        return {
            loginForm: {
                username: '',
                password: ''
            },
            error: '' // Thêm biến error để lưu thông báo lỗi
        };
    },
    methods: {
        async login() {
            if (!this.loginForm.username || !this.loginForm.password) {
                this.error = 'Username and password are required!';
                return;
            }

            try {
                var url = `${process.env.VUE_APP_BASE_API_URL}/Authentications/Login`;
                const response = await axios.post(url, {
                    username: this.loginForm.username,
                    password: this.loginForm.password
                });

                console.log(response);


                if (response.status === 200) {
                    console.log('Đăng nhập thành công:', response.data);
                    localStorage.setItem('token', response.data.token);
                    this.$router.push('/admin').then(() => {
                        window.location.reload();
                    });
                } else if (response.status === 400) {
                    console.error('Đăng nhập không thành công:', response.response.data);
                    if (response.response.data) {
                        this.error = response.response.data; // Sử dụng thông báo lỗi từ API
                    } else {
                        this.error = 'Unknown error occurred!'; // Nếu không có thông báo lỗi từ API
                    }
                } else {
                    console.error('Đăng nhập không thành công:', response.statusText);
                    this.error = 'Unknown error occurred!'; // Hiển thị thông báo lỗi mặc định
                }

            } catch (error) {
                console.error('Đã xảy ra lỗi khi đăng nhập:', error);
                this.error = error.response.data; // Hiển thị thông báo lỗi khi có lỗi trong quá trình đăng nhập
            }
        }
    },

    created() {
        console.log('Component created');
    }
}
</script>

<style scoped>
@import '@/assets/css/style.css';
</style>
