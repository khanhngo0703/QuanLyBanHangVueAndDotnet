<!-- <template>
    <div class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header">
                                        <h3 class="text-center font-weight-light my-4">Password Recovery</h3>
                                    </div>
                                    <div class="card-body">
                                        <div class="small mb-3 text-muted">Enter your email address and we will send you
                                            a link to reset your password.</div>
                                        <form @submit.prevent="submitForm">
                                            <div class="form-floating mb-3">
                                                <input class="form-control" id="inputEmail" type="email" v-model="email"
                                                    placeholder="name@example.com" />
                                                <label for="inputEmail">Email address</label>
                                            </div>
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <router-link class="small" to="/login">Return to login</router-link>
                                                <button type="submit" class="btn btn-primary">Reset Password</button>
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="register.html">Need an account? Sign up!</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2023</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
    </div>

</template>

<script>
import axios from 'axios';
export default {
    name: 'ForgotPassword',
    data() {
        return {
            email: '',
        };
    },
    methods: {
        async submitForm() {
            try {
                var url = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/forgotpassword`;

                await axios.post(url, { email: this.email });
                alert('Email reset password đã được gửi.');
            } catch (error) {
                console.error('Lỗi:', error);
                alert('Đã có lỗi xảy ra. Vui lòng thử lại sau.');
            }
        },
        async confirmCode() {
            try {
                var url = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/confirmcode`;

                await axios.post(url, { email: this.email, code: this.code });
                // Redirect to reset password page or show reset password form
                this.$router.push(`/resetpassword?email=${this.email}&code=${this.code}`);
            } catch (error) {
                console.error('Lỗi:', error);
                alert('Mã code không hợp lệ. Vui lòng thử lại.');
            }
        },

    },
};
</script>

<style scoped>
@import '@/assets/css/style.css';
</style> -->
<!-- <template>    
    <div class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header">
                                        <h3 class="text-center font-weight-light my-4">Password Recovery</h3>
                                    </div>
                                    <div class="card-body">
                                        <div v-if="!showCodeInput" class="small mb-3 text-muted">Enter your email address and we will send you a link to reset your password.</div>
                                        <div v-if="showCodeInput" class="small mb-3 text-muted">Enter the confirmation code sent to your email.</div>
                                        <form @submit.prevent="submitForm">
                                            <div v-if="!showCodeInput" class="form-floating mb-3">
                                                <input class="form-control" id="inputEmail" type="email" v-model="email" placeholder="name@example.com" />
                                                <label for="inputEmail">Email address</label>
                                            </div>
                                            <div v-if="showCodeInput" class="form-floating mb-3">
                                                <input class="form-control" id="inputCode" type="text" v-model="code" placeholder="Confirmation code" />
                                                <label for="inputCode">Confirmation Code</label>
                                            </div>
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <router-link v-if="showCodeInput" class="small" to="/login">Return to login</router-link>
                                                <button type="submit" class="btn btn-primary">{{ showCodeInput ? 'Confirm Code' : 'Reset Password' }}</button>
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="register.html">Need an account? Sign up!</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2023</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'ForgotPassword',
    data() {
        return {
            email: '',
            code: '',
            showCodeInput: false
        };
    },
    methods: {
        async submitForm() {
            try {
                if (!this.showCodeInput) {
                    var url = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/forgotpassword`;
                    await axios.post(url, { email: this.email });
                    this.showCodeInput = true;
                    alert('Email reset password đã được gửi.');
                } else {
                    var confirmUrl = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/confirmcode`;
                    await axios.post(confirmUrl, { email: this.email, code: this.code });
                    this.$router.push(`/resetpassword?email=${this.email}&code=${this.code}`);
                }
            } catch (error) {
                console.error('Lỗi:', error);
                alert('Đã có lỗi xảy ra. Vui lòng thử lại sau.');
            }
        },
    },
};
</script>

<style scoped>
@import '@/assets/css/style.css';
</style> -->
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
                                        <h3 class="text-center font-weight-light my-4">Password Recovery</h3>
                                    </div>
                                    <div class="card-body">
                                        <div v-if="!showCodeInput && !showPasswordInput" class="small mb-3 text-muted">Enter your email address and we will send you a link to reset your password.</div>
                                        <div v-if="showCodeInput && !showPasswordInput" class="small mb-3 text-muted">Enter the confirmation code sent to your email.</div>
                                        <div v-if="showPasswordInput" class="small mb-3 text-muted">Enter your new password.</div>
                                        <form @submit.prevent="submitForm">
                                            <div v-if="!showCodeInput && !showPasswordInput" class="form-floating mb-3">
                                                <input class="form-control" id="inputEmail" type="email" v-model="email" placeholder="name@example.com" />
                                                <label for="inputEmail">Email address</label>
                                            </div>
                                            <div v-if="showCodeInput && !showPasswordInput" class="form-floating mb-3">
                                                <input class="form-control" id="inputCode" type="text" v-model="code" placeholder="Confirmation code" />
                                                <label for="inputCode">Confirmation Code</label>
                                            </div>
                                            <div v-if="showPasswordInput" class="form-floating mb-3">
                                                <input class="form-control" id="inputPassword" type="password" v-model="newPassword" placeholder="New Password" />
                                                <label for="inputPassword">New Password</label>
                                            </div>
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <router-link v-if="showCodeInput || showPasswordInput" class="small" to="/login">Return to login</router-link>
                                                <button type="submit" class="btn btn-primary">{{ showCodeInput ? 'Confirm Code' : 'Reset Password' }}</button>
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="register.html">Need an account? Sign up!</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2023</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'ForgotPassword',
    data() {
        return {
            email: '',
            code: '',
            newPassword: '',
            showCodeInput: false,
            showPasswordInput: false
        };
    },
    methods: {
        async submitForm() {
            try {
                if (!this.showCodeInput && !this.showPasswordInput) {
                    var url = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/forgotpassword`;
                    await axios.post(url, { email: this.email });
                    this.showCodeInput = true;
                    alert('Email reset password đã được gửi.');
                } else if (this.showCodeInput && !this.showPasswordInput) {
                    var confirmUrl = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/confirmcode`;
                    await axios.post(confirmUrl, { email: this.email, code: this.code });
                    this.showPasswordInput = true;
                } else {
                    var resetUrl = `${process.env.VUE_APP_BASE_API_URL}/ForgotPassword/resetpassword`;
                    await axios.post(resetUrl, { email: this.email, newPassword: this.newPassword });
                    this.$router.push('/login');
                    alert('Đặt lại mật khẩu thành công.');
                }
            } catch (error) {
                console.error('Lỗi:', error);
                alert('Đã có lỗi xảy ra. Vui lòng thử lại sau.');
            }
        },
    },
};
</script>

<style scoped>
@import '@/assets/css/style.css';
</style>
