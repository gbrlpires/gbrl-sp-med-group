import React, { Component } from 'react';

import './NavbarMobile.css'

import Hamburger from '../../Hamburger/Hamburger';
import Navbar from '../__Navbar/Navbar';

function NavbarMobile() {
  return(
        <nav className="navbar">
            <Hamburger />
            <Navbar />
        </nav>
   
      
);
}

export default NavbarMobile;