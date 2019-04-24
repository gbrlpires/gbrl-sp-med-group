import React, { Component } from 'react';
import logo from '../../assets/img/spmed-logo.png';

import './Header.css';
import '../../assets/position.css';

import NavbarMobile from '../NavbarMobile/NavbarMobile';
import Navbar from '../Navbar/Navbar'

function Header() {
  return(
    <header className="header">
        <div className="wrapper header-flexbox">
            <div className="header__img">
                <img src={logo} />
            </div>
            <NavbarMobile />
            <Navbar />
        </div> 
    </header>
);
}

export default Header;