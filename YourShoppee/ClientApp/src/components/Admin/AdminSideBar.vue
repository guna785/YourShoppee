<script lang="ts">
import {Vue} from 'vue-class-component';
export default class AdminSideBar extends Vue{
    
}
</script>
<template>
    
<div class="offcanvas offcanvas-start bg-dark text-white sidebar-nav" tabindex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
 
  <div class="offcanvas-body p-0">
    <nav class="navbar-dark">
        <ul class="navbar-nav">
            <li>
                <div class="text-muted small fw-bold text-uppercase px-3">CORE</div>
            </li>
            <li>
                <a href="#" class="nav-link px-3 active">
                    <span class="me-2">
                        <i class="bi bi-speedometer2"></i>
                    </span>
                    <span>Dashboard</span>
                </a>
            </li>
            <li class="my-4">
                <hr class="dropdown-divider" />
            </li>
            <li>
                <div class="text-muted small fw-bold text-uppercase px-3">Interface</div>
            </li>
            <li>
                <a class="nav-link px-3 sidebar-link"
                    data-bs-toggle="collapse"
                    href="#collapseExample"
                    role="button"
                    aria-expanded="false"
                    aria-controls="collapseExample"
                > <span class="me-2">
                        <i class="bi bi-cart4"></i>
                    </span>
                    <span>Products</span>
                    <span class="right-icon ms-auto">
                        <i class="bi bi-chevron-down"></i>
                    </span>
                </a>
                <div class="collapse" id="collapseExample">
                    <div>
                       <ul class="navbar-nav ps-3">
                           <li>
                               <a href="#" class="nav-link px-3">
                                   <span class="me-2">
                                       <i class="bi bi-circle-fill"></i>
                                   </span>
                                   <span>Products</span>
                               </a> 
                           </li>
                           <li>
                                <a href="#" class="nav-link px-3">
                                   <span class="me-2">
                                       <i class="bi bi-circle-fill"></i>
                                   </span>
                                   <span>Product Group</span>
                               </a>
                           </li>
                            <li>
                                <a href="#" class="nav-link px-3">
                                   <span class="me-2">
                                       <i class="bi bi-circle-fill"></i>
                                   </span>
                                   <span>Product Category</span>
                               </a>
                           </li>
                            <li>
                                <a href="#" class="nav-link px-3">
                                   <span class="me-2">
                                       <i class="bi bi-circle-fill"></i>
                                   </span>
                                   <span>Product Type</span>
                               </a>
                           </li>
                            <li>
                                <a href="#" class="nav-link px-3">
                                   <span class="me-2">
                                       <i class="bi bi-circle-fill"></i>
                                   </span>
                                   <span>Units</span>
                               </a>
                           </li>
                       </ul>
                    </div>
                </div>
            </li>
        </ul>
    </nav>
  </div>
</div>
</template>