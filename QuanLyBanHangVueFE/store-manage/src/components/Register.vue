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
                    <h3 class="text-center font-weight-light my-4">Register</h3>
                  </div>
                  <div class="card-body">
                    <form form @submit.prevent="register" class="register">
                      <div class="form-floating mb-3">
                        <input class="form-control" type="text" placeholder="Username" id="username"
                          v-model="registerForm.username" required />
                        <label for="inputUsername">Username</label>
                      </div>
                      <div class="form-floating mb-3">
                        <input class="form-control" type="email" placeholder="abc@gmail.com" id="email"
                          v-model="registerForm.email" required />
                        <label for="inputEmail">Email</label>
                      </div>
                      <div class="form-floating mb-3">
                        <input class="form-control" type="password" id="password" v-model="registerForm.password"
                          placeholder="Password" required />
                        <label for="inputPassword">Password</label>
                      </div>
                      <div class="form-floating mb-3">
                        <input class="form-control" type="password" id="retypePassword"
                          v-model="registerForm.retypePassword" placeholder="Repeat Password" required />
                        <label for="inputPassword">Repeat Password</label>
                        <div>
                          <span v-if="passwordMismatch" class="error-message">Mật khẩu và mật khẩu nhập lại không
                            khớp.</span>
                        </div>
                      </div>
                      <div class="d-flex align-items-center justify-content-center mt-4 mb-0">
                        <button type="submit" class="btn btn-primary">Register</button>
                      </div>
                    </form>
                  </div>
                  <div class="card-footer text-center py-3">
                    <div class="small"><router-link to="/login">Bạn đã có tài khoản?Đăng
                        nhập!</router-link></div>
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
      registerForm: {
        username: '',
        email: '',
        password: '',
        retypePassword: '' // Thêm trường retypePassword vào form data
      },
      token: '', // Lưu trữ token sau khi đăng nhập thành công
      passwordMismatch: false // Thêm passwordMismatch vào data để kiểm tra mật khẩu nhập lại
    }
  },
  methods: {
    async register() {
      // Kiểm tra xem mật khẩu và mật khẩu nhập lại có khớp nhau không
      if (this.registerForm.password !== this.registerForm.retypePassword) {
        // Nếu mật khẩu không khớp, hiển thị thông báo lỗi
        this.passwordMismatch = true;
        return;
      }

      try {
        var url = `${process.env.VUE_APP_BASE_API_URL}/Authentications/Register`;
        const response = await axios.post(url, {
          username: this.registerForm.username,
          email: this.registerForm.email,
          password: this.registerForm.password,
          Role: 'CUSTOMER' // Thêm trường Role với giá trị 'CUSTOMER'
        });
        console.log(response.data);

        this.$router.push('/login');
      } catch (error) {
        console.error('Đăng ký không thành công:', error.response ? error.response.data : error.message);
      }
    }
  },
  created() {
    //debugger
    console.log('Component created');
    this.titlePage = "Component Setting in created";
    //this.loadData();
  }
}

</script>
<style scoped>
@import '@/assets/css/style.css';
</style>
