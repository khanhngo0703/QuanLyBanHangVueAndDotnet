<template>
    <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
        <!-- Navbar Brand-->
        <a class="navbar-brand ps-3" href="index.html">Start Bootstrap</a>
        <!-- Sidebar Toggle-->
        <button class="btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0" id="sidebarToggle" href="#!"><i
                class="fas fa-bars"></i></button>
        <!-- Navbar Search-->
        <form class="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
            <div class="input-group">
                <input class="form-control" type="text" placeholder="Search for..." aria-label="Search for..."
                    aria-describedby="btnNavbarSearch" />
                <button class="btn btn-primary" id="btnNavbarSearch" type="button"><i
                        class="fas fa-search"></i></button>
            </div>
        </form>
        <!-- Navbar-->
        <ul class="navbar-nav ms-auto ms-md-0 me-3 me-lg-4">
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button" data-bs-toggle="dropdown"
                    aria-expanded="false"><i class="fas fa-user fa-fw"></i></a>
                <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
                    <li><a class="dropdown-item" href="#!">Settings</a></li>
                    <li><a class="dropdown-item" href="#!">Activity Log</a></li>
                    <li>
                        <hr class="dropdown-divider" />
                    </li>
                    <li><button class="dropdown-item" @click="logout">Logout</button></li>
                </ul>
            </li>
        </ul>
    </nav>
    <div id="layoutSidenav">
        <div id="layoutSidenav_nav">
            <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                <div class="sb-sidenav-menu">
                    <div class="nav">
                        <div class="sb-sidenav-menu-heading">Core</div>
                        <a class="nav-link" href="index.html">
                            <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                            Dashboard
                        </a>
                        <div class="sb-sidenav-menu-heading">Interface</div>
                        <a class="nav-link collapsed" href="#" data-bs-toggle="collapse"
                            data-bs-target="#collapseLayouts" aria-expanded="false" aria-controls="collapseLayouts">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Layouts
                            <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                        </a>
                        <div class="collapse" id="collapseLayouts" aria-labelledby="headingOne"
                            data-bs-parent="#sidenavAccordion">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a class="nav-link" href="layout-static.html">Static Navigation</a>
                                <a class="nav-link" href="layout-sidenav-light.html">Light Sidenav</a>
                            </nav>
                        </div>
                        <a class="nav-link collapsed" href="#" data-bs-toggle="collapse" data-bs-target="#collapsePages"
                            aria-expanded="false" aria-controls="collapsePages">
                            <div class="sb-nav-link-icon"><i class="fas fa-book-open"></i></div>
                            Pages
                            <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                        </a>
                        <div class="collapse" id="collapsePages" aria-labelledby="headingTwo"
                            data-bs-parent="#sidenavAccordion">
                            <nav class="sb-sidenav-menu-nested nav accordion" id="sidenavAccordionPages">
                                <a class="nav-link collapsed" href="#" data-bs-toggle="collapse"
                                    data-bs-target="#pagesCollapseAuth" aria-expanded="false"
                                    aria-controls="pagesCollapseAuth">
                                    Authentication
                                    <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                                </a>
                                <div class="collapse" id="pagesCollapseAuth" aria-labelledby="headingOne"
                                    data-bs-parent="#sidenavAccordionPages">
                                    <nav class="sb-sidenav-menu-nested nav">
                                        <a class="nav-link" href="login.html">Login</a>
                                        <a class="nav-link" href="register.html">Register</a>
                                        <a class="nav-link" href="password.html">Forgot Password</a>
                                    </nav>
                                </div>
                                <a class="nav-link collapsed" href="#" data-bs-toggle="collapse"
                                    data-bs-target="#pagesCollapseError" aria-expanded="false"
                                    aria-controls="pagesCollapseError">
                                    Error
                                    <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                                </a>
                                <div class="collapse" id="pagesCollapseError" aria-labelledby="headingOne"
                                    data-bs-parent="#sidenavAccordionPages">
                                    <nav class="sb-sidenav-menu-nested nav">
                                        <a class="nav-link" href="401.html">401 Page</a>
                                        <a class="nav-link" href="404.html">404 Page</a>
                                        <a class="nav-link" href="500.html">500 Page</a>
                                    </nav>
                                </div>
                            </nav>
                        </div>
                        <div class="sb-sidenav-menu-heading">Addons</div>
                        <a class="nav-link" href="charts.html">
                            <div class="sb-nav-link-icon"><i class="fas fa-chart-area"></i></div>
                            Charts
                        </a>
                        <a class="nav-link" href="tables.html">
                            <div class="sb-nav-link-icon"><i class="fas fa-table"></i></div>
                            Tables
                        </a>
                    </div>
                </div>
                <div class="sb-sidenav-footer">
                    <div class="small">Logged in as:</div>
                    Start Bootstrap
                </div>
            </nav>
        </div>
        <div id="layoutSidenav_content">
            <main>
                <div class="container-fluid px-4">
                    <div class="card mb-4">
                        <h1>Product Manage</h1>
                        <!-- <button class="dropdown-item" @click="logout">Logout</button> -->
                        <div class="control-box">
                            <button class="btn btn-success" @click="onCreateClick()">Create</button>
                        </div>
                        <div class="form-control">
                            <nav class="navbar navbar-light bg-light">
                                <form class="form-inline" @submit.prevent="onSubmit">
                                    <div class="row">
                                        <div class="col-md-9">
                                            <input class="form-control mr-sm-2" type="search" placeholder="Search"
                                                aria-label="Search" v-model="searchKeyword">
                                        </div>
                                        <div class="col-md-3">
                                            <button class="btn btn-outline-success my-2 my-sm-0"
                                                type="submit">Search</button>
                                        </div>
                                    </div>
                                </form>
                            </nav>
                        </div>
                        <div class="table-box">
                            <table class="table table-striped">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Name</th>
                                        <th>Image</th>
                                        <th>Price</th>
                                        <th>Bar Code</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr v-for="p in productData" :key="p.id">
                                        <td>{{ p.id }}</td>
                                        <td>{{ p.productName }}</td>
                                        <td><img :src="p.imageProduct" width="80"></td>
                                        <td>{{ p.price }}</td>
                                        <td>{{ p.barCode }}</td>
                                        <td>
                                            <div class="btn-group" role="group" aria-label="Basic example">
                                                <button type="button" class="btn btn-warning"
                                                    @click="onUpdateClick(p)">Update</button>
                                                <button type="button" class="btn btn-danger">Delete</button>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                            <div class="khoi-phan-trang">
                                <nav aria-label="Page navigation example">
                                    <ul class="pagination">
                                        <li class="page-item">
                                            <a class="page-link" href="#" aria-label="Previous" @click="previousPage">
                                                <span aria-hidden="true">&laquo;</span>
                                            </a>
                                        </li>
                                        <li class="page-item" v-for="page in totalPages" :key="page">
                                            <a class="page-link" href="#" @click="changePage(page)">{{ page }}</a>
                                        </li>
                                        <li class="page-item">
                                            <a class="page-link" href="#" aria-label="Next" @click="nextPage">
                                                <span aria-hidden="true">&raquo;</span>
                                            </a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                        <div class="modal fade" ref="productModal" id="productModal" tabindex="-1" role="dialog"
                            aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">Create New Product</h5>
                                        <button type="button" class="btn-close" data-bs-dismiss="modal"
                                            aria-label="Close">
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <form>
                                            <div class="form-group">
                                                <label for="recipient-name" class="col-form-label">Product Name:</label>
                                                <input type="text" class="form-control" id="recipient-name"
                                                    v-model="currentProduct.productName">
                                            </div>
                                            <div class="form-group">
                                                <label for="imageProduct" class="col-form-label">Product Image:</label>
                                                <input type="file" class="form-control" id="imageProduct"
                                                    @change="onFileChange">
                                            </div>
                                            <div class="form-group">
                                                <label for="recipient-name" class="col-form-label">Price:</label>
                                                <input type="number" class="form-control" id="recipient-name"
                                                    v-model="currentProduct.price">
                                            </div>
                                            <div class="form-group">
                                                <label for="recipient-name" class="col-form-label">Bar Code:</label>
                                                <input type="text" class="form-control" id="recipient-name"
                                                    v-model="currentProduct.barCode">
                                            </div>
                                        </form>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-secondary"
                                            data-dismiss="modal">Close</button>
                                        <button type="button" class="btn btn-primary"
                                            @click="onSaveClick()">Save</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
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
</template>

<script>
import axios from 'axios';
import { Modal } from 'bootstrap';
import { toast } from 'vue3-toastify';
import 'vue3-toastify/dist/index.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
// Import JavaScript
import '@/assets/js/scripts';
import { RouterLink } from 'vue-router';

export default {
    name: "Product",
    components: {
        Modal, toast
    },
    setup() {
        const success = () => {
            toast("Success !", {
                autoClose: 1000,
                type: "success"
            });
        }
        return { success };
    },
    data() {
        return {
            productData: [],
            productModal: null,
            currentProduct: {
                id: 0,
                productName: "Name",
                imageProduct: "Image",
                price: 0,
                barCode: "Bar Code"
            },
            searchKeyword: '',
            currentPage: 1, // Trang hiện tại
            pageSize: 5,   // Kích thước trang (số lượng sản phẩm trên mỗi trang)
            totalItems: 0,  // Tổng số sản phẩm
            totalPages: 0,
        }
    },
    methods: {
        loadProductData() {
            var url = process.env.VUE_APP_BASE_API_URL + `/Products/GetAll`;
            axios.get(url).then((response) => {
                console.log(response);
                //this.productData = response.data;
                this.totalItems = response.data.length; // Số lượng sản phẩm trong dữ liệu nhận được
                this.totalPages = Math.floor(this.totalItems / this.pageSize);
                if (this.totalItems % this.pageSize !== 0) {
                    this.totalPages++; // Nếu còn dư sản phẩm, tăng totalPages lên 1
                }

                let startIndex = (this.currentPage - 1) * this.pageSize;
                let endIndex = this.currentPage * this.pageSize;

                // Cắt lát productData để chỉ lấy số lượng sản phẩm tương ứng với pageSize
                this.productData = response.data.slice(startIndex, endIndex);
                // Nếu số lượng sản phẩm vượt quá 10, tăng số trang lên 1

            }).catch((error) => {
                console.log(error.response);
            })
        },

        changePage(page) {
            this.currentPage = page;
            this.loadProductData();
        },
        previousPage() {
            if (this.currentPage > 1) {
                this.currentPage--;
                this.loadProductData();
            }
        },
        nextPage() {
            if (this.currentPage < this.totalPages) {
                this.currentPage++;
                this.loadProductData();
            }
        },
        onCreateClick() {
            this.currentProduct = {
                id: 0,
                productName: "Name",
                imageProduct: "",
                price: 0,
                barCode: "Bar Code"
            }
            this.productModal.show();
        },
        onUpdateClick(p) {
            this.currentProduct = Object.assign({}, p);// clone d
            this.productModal.show();
        },        
        onFileChange(event) {
            const file = event.target.files[0];
            if (file) {
                // Kiểm tra phần mở rộng của file
                const validExtensions = ['.png', '.jpg', '.jpeg'];
                const fileName = file.name;
                const fileExtension = fileName.substring(fileName.lastIndexOf('.')).toLowerCase();

                if (!validExtensions.includes(fileExtension)) {
                    alert('Vui lòng chọn một file ảnh có định dạng .png, .jpg hoặc .jpeg!');
                    return;
                }

                const formData = new FormData();
                formData.append('image', file);

                // Gọi API để upload ảnh
                axios.post(process.env.VUE_APP_BASE_API_URL + '/Products/UploadImage', formData, {
                    headers: {
                        'Content-Type': 'multipart/form-data',
                    },
                })
                    .then(response => {
                        // Lưu URL ảnh trả về từ API vào currentProduct.imageProduct
                        this.currentProduct.imageProduct = response.data.imageUrl;
                        console.log(this.currentProduct.imageProduct);
                    })
                    .catch(error => {
                        console.log('Error uploading image:', error);
                    });
            }
        },

        onSaveClick() {
            if (this.currentProduct.id == 0) {
                var url = process.env.VUE_APP_BASE_API_URL + `/Products/Create`
                axios.post(url, this.currentProduct).then((respone) => {
                    console.log(respone.data);
                    //bat thong bao thanh cong
                    this.success();

                    // tat modal
                    this.productModal.hide();

                    // goi lai load du lieu product
                    this.loadProductData();
                }).catch((error) => {
                    console.log(error)
                })
            } else {
                var url = process.env.VUE_APP_BASE_API_URL + `/Products/Update`
                axios.put(url, this.currentProduct).then((respone) => {
                    console.log(respone.data);
                    console.log(this.currentProduct);
                    //bat thong bao thanh cong
                    this.success();

                    // tat modal
                    this.productModal.hide();

                    // goi lai load du lieu product
                    this.loadProductData();
                }).catch((error) => {
                    console.log(error)
                })
            }
        },
        logout() {
            // Xử lý đăng xuất ở đây
            // Ví dụ: xóa token khỏi Local Storage và chuyển hướng đến trang đăng nhập
            localStorage.removeItem('token');
            this.$router.push('/login');
        },

        onSubmit() {
            var url = process.env.VUE_APP_BASE_API_URL + `/Products/fullFilter`;
            var requestData = {
                filterParams: [
                    {
                        colName: "productName",
                        _operator: "like",
                        value: this.searchKeyword
                    }
                ],
                index: 1,
                size: 10,
                sortAsc: true,
                sortCol: "productName"
            };

            axios.post(url, requestData)
                .then(response => {
                    this.productData = response.data;
                    this.totalItems = this.productData.length; // Số lượng sản phẩm trong dữ liệu nhận được
                    this.totalPages = Math.ceil(this.totalItems / this.pageSize);
                    console.log(this.productData);
                })
                .catch(error => {
                    console.error('Lỗi khi tìm kiếm sản phẩm:', error);
                });
        }

    },
    mounted() {
        this.loadProductData();
        console.log(this.totalPages);
        //load Modal
        this.productModal = new Modal(this.$refs.productModal);
    }

}
</script>

<style>
@import '@/assets/css/style.css';
</style>