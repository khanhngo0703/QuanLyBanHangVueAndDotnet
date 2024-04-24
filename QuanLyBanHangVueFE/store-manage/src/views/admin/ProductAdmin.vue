<template>
    <div class="home">
        <Product />
    </div>
</template>

<script>
import Product from '@/components/admin/Product.vue';

export default {
    name: 'ProductAdmin',
    components: {
        Product
    }
}
</script>