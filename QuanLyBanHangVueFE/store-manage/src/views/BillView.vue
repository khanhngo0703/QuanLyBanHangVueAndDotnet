<template>
    <div class="title-box">
        <h1>Place An Order</h1>
    </div>
    <div class="controls-box">
        <Select2 v-model="myValue" :options="productOptions" @change="console.log($event)"
            @select="onSelectProduct($event)" />
    </div>
    <div class="title-box">
        <h3 class="mt-5">List Order</h3>
    </div>
    <div class="table-box">
        <table class="table table-bordered table-striped">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Total Price</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="(item, index) in billDetail" :key="item.product">
                    <td>{{ index + 1 }}</td>
                    <td>{{ item.productId }}</td>
                    <td>{{ item.product.productName }}</td>
                    <td>{{ item.price }}</td>
                    <td>
                        <span class="mr-5"><input type="number" step="1" class="form-control input-quantity"
                                v-model="item.quantity"></span>
                    </td>
                    <td>{{ (item.price * item.quantity).toFixed(2) }}</td>
                    <td>
                        <button class="btn btn-danger" @click="onClickDelete(item)">Delete</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="thanh-toan">
        <button class="btn btn-success" v-if="billDetail.length > 0" @click="onConfirmBill()">Confirm</button>
    </div>
</template>

<script>
import Select2 from "vue3-select2-component";
import axios from 'axios';
import moment from 'moment';

export default {
    name: "BillView",
    components: {
        Select2
    },
    data() {
        return {
            productLists: [],
            productOptions: [],
            billDetail: [],
            bill: [],
        }
    },
    methods: {
        loadProductData() {
            var url = process.env.VUE_APP_BASE_API_URL + `/Products/GetAll`;
            axios.get(url).then((respone) => {
                this.productLists = respone.data;
                this.productOptions = respone.data.map(element => {
                    var obj = {
                        id: element.id,
                        text: `${element.productName} - ${element.barCode}`
                    }
                    return obj;
                })
            }).catch((error) => {
                console.log(error)
            })
        },
        onSelectProduct(p) {
            var productSelected = this.productLists.find(element => element.id == p.id);
            console.log(productSelected);

            var clone = Object.assign({}, productSelected);

            var item = {
                productId: clone.id,
                quantity: 1,
                price: clone.price,
                billId: 0,
                product: clone
            }
            console.log(item);
            this.billDetail.push(item);

        },
        onClickDelete(p) {
            this.billDetail.splice(this.billDetail.indexOf(p), 1);
        },
        onConfirmBill() {
            this.bill = {
                id: 0,
                code: "ddfgregter",
                date: moment(new Date()).format("YYYY-MM-DDTHH:mm:ss"),
                billDetails: this.billDetail
            }
            console.log(this.bill);

            var url = process.env.VUE_APP_BASE_API_URL + "/Bills/InsertFullDetail"
            axios.post(url, this.bill).then((respone) => {
                console.log(respone);
                alert("success");                    
            }).catch((error) => {
                console.log(error)
            })
        }
    },
    mounted() {
        this.loadProductData();
    }
}
</script>

<style>
.input-quantity {
    width: 50px !important;
    margin: 0 auto;
}
</style>