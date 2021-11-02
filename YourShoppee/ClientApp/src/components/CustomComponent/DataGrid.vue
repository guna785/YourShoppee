<script lang="ts">
  import {Options,Vue} from 'vue-class-component';
    @Options({
        props:{
           dataUri:String
        }
    })
  export default class DataGrid extends Vue{
      colums:any=[];
      data:any=[];
      sortOrders:any={};
      sortKey:String="";
      showRecordLists:any=[5,10,15,25,50,75,100];
      currentShow:any=10;
      
  }
</script>
<template>
    <div class="container-fluid">
        
        <div class="col-md-12">
            <div class="row">
            <span class="p-2 me-auto">Show</span>    
            <select v-model="currentShow" class="form-select me-auto" style="width:80px;">
                <option v-for="sh in showRecordLists" :key="sh" :value="sh">
                    {{sh}}
                </option>
            </select>
            <div class="input-group mb-3 ms-auto">
                <input type="text" class="form-control" placeholder="Recipient's username" aria-label="Recipient's username" aria-describedby="basic-addon2">
                <span class="input-group-text" id="basic-addon2">@example.com</span>
            </div>
        </div>
        </div>
         <div class="row">
<div class="col-md-12">
<table class="table table-striped"></table>
        </div>
        </div>
        
        
    </div>
    
</template>
<style>
table {
  border: 2px solid #42b983;
  border-radius: 3px;
  background-color: #fff;
}

th {
  background-color: #42b983;
  color: rgba(255, 255, 255, 0.66);
  cursor: pointer;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}

td {
  background-color: #f9f9f9;
}

th,
td {
  min-width: 120px;
  padding: 10px 20px;
}

th.active {
  color: #fff;
}

th.active .arrow {
  opacity: 1;
}

.arrow {
  display: inline-block;
  vertical-align: middle;
  width: 0;
  height: 0;
  margin-left: 5px;
  opacity: 0.66;
}

.arrow.asc {
  border-left: 4px solid transparent;
  border-right: 4px solid transparent;
  border-bottom: 4px solid #fff;
}

.arrow.dsc {
  border-left: 4px solid transparent;
  border-right: 4px solid transparent;
  border-top: 4px solid #fff;
}
</style>