import React, { Component } from 'react';
import PropTypes from 'prop-types';


import './InputTypeText.css'


export class InputTypeText extends Component {

        static defaultProps {
            value: ""
        };

        static propTypes {
            id: PropTypes.string.isRequired,
            name: PropTypes.string.isRequired,
            value: PropTypes.string
        }


}
  export default InputTypeText;