﻿:root {
    --gray: #3495e;
    --darkgrey: #2c3e50;
}

select {
    appearance: none;
    outline: 10px red;
    border: 0;
    box-shadow: none;
    flex: 1;
    padding: 0 1em;
    color: #fff;
    background-color: var(--darkgray);
    background-image: none;
    cursor: pointer;
}



body {
    background-color: #ddd;
    font-family: Arial, sans-serif;
    padding: 0px;
}

h3 {
    color: #333;
}

.flex-container {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
    background-color: #ddd;
}

.flex-item {
    box-sizing: border-box;
    width: 48%;
    margin-bottom: 10px;
    padding: 10px;
    background-color: #ddd;
    border-radius: 5px;
}

.flex-item100percent {
    box-sizing: border-box;
    width: 100%;
    margin-bottom: 10px;
    padding: 10px;
    background-color: #ddd;
    border-radius: 5px;
}

label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
}

input, textarea, button {
    width: calc(100% - 12px);
    padding: 5px;
    margin-bottom: 10px;
    box-sizing: border-box;
    border: none;
    border-radius: 8px;
    background-color: rgba(51, 51, 51, 0.05);
    color: rgb(0, 0, 0);
}

button {
    background-color: rgba(51, 51, 51, 0.05);
    border-radius: 8px;
    border-width: 0;
    color: #333333;
    cursor: pointer;
    display: inline-block;
    font-family: "Haas Grot Text R Web", "Helvetica Neue", Helvetica, Arial, sans-serif;
    font-size: 14px;
    font-weight: 500;
    line-height: 20px;
    list-style: none;
    margin: 0;
    padding: 10px 12px;
    text-align: center;
    transition: all 200ms;
    vertical-align: baseline;
    white-space: nowrap;
    user-select: none;
    -webkit-user-select: none;
    touch-action: manipulation;
    height: 100px;
}

.button-9 {
    appearance: button;
    backface-visibility: hidden;
    background-color: #405cf5;
    border-radius: 6px;
    border-width: 0;
    box-shadow: rgba(50, 50, 93, .1) 0 0 0 1px inset,rgba(50, 50, 93, .1) 0 2px 5px 0,rgba(0, 0, 0, .07) 0 1px 1px 0;
    box-sizing: border-box;
    color: #fff;
    cursor: pointer;
    font-family: -apple-system,system-ui,"Segoe UI",Roboto,"Helvetica Neue",Ubuntu,sans-serif;
    font-size: 100%;
    height: 44px;
    line-height: 1.15;
    margin: 12px 0 0;
    outline: none;
    overflow: hidden;
    padding: 10px;
    position: relative;
    text-align: center;
    text-transform: none;
    transform: translateZ(0);
    transition: all .2s,box-shadow .08s ease-in;
    user-select: none;
    -webkit-user-select: none;
    touch-action: manipulation;
    width: 7%;
}

.button-9:disabled {
    cursor: default;
}

.button-9:focus {
    box-shadow: rgba(50, 50, 93, .1) 0 0 0 1px inset, rgba(50, 50, 93, .2) 0 6px 15px 0, rgba(0, 0, 0, .1) 0 2px 2px 0, rgba(50, 151, 211, .3) 0 0 0 4px;
}

.radio-options {
    display: flex;
    align-items: center;
}

.plus {
    cursor: pointer;
    width: 20px;
    height: 20px;
    background-color: #405cf5;
    border-radius: 50%;
    color: #fff;
    text-align: center;
    line-height: 20px;
}

.radio-option {
    background: #4d4a4a;
    height: 40px;
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin: 0 10px;
    border-radius: 5px;
    cursor: pointer;
    padding: 0 10px;
    border: 2px solid lightgrey;
    transition: all 0.3s ease;
    background-color: rgba(51, 51, 51, 0.05);
}

.radio-option .dot {
    height: 20px;
    width: 20px;
    background: #d9d9d9;
    border-radius: 50%;
    position: relative;
}

.radio-option .dot::before {
    position: absolute;
    content: "";
    top: 4px;
    left: 4px;
    width: 12px;
    height: 12px;
    background: #0069d9;
    border-radius: 50%;
    opacity: 0;
    transform: scale(1.5);
    transition: all 0.3s ease;
}
