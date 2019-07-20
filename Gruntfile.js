// Gruntfile.js

// our wrapper function (required by grunt and its plugins)
// all configuration goes inside this function
var fs = require('fs');
var packageJson = JSON.parse(fs.readFileSync('./package.json'));
var plugins = packageJson.buildSettings.plugins;
var css = packageJson.buildSettings.css;
var folders = { 'app/dashboard/src/scripts.min.js': 'app/dashboard/**/*.js', 'app/searchpage/src/scripts.min.js': 'app/searchpage/**/*.js' };
var jsonObj = JSON.parse(fs.readFileSync('./types.json'));
var CtrlFolder="D:/kaa_newAPI_version/EmployeeWebApi2/WebApi2_Customer/Application/Application/Controllers/editAndView";
var DalFolder="D:/kaa_newAPI_version/EmployeeWebApi2/WebApi2_Customer/Application/Application.DAL/Application.DAL/editAndView";
var SvcFolder="D:/kaa_newAPI_version/EmployeeWebApi2/WebApi2_Customer/Application/Application.Service/Application.Service/editAndView";
var MlFolder="D:/kaa_newAPI_version/EmployeeWebApi2/WebApi2_Customer/Application/Application.Model/Application.Model/editAndView";

function IBusinessObject() {
    var dynamicstring = '';
    var arr;
    arr = Object.keys(jsonObj[0]);
    arr.forEach(function(element) {
        var dataType = Number.isInteger(jsonObj[0][element]) ? 'int' : 'string';
        console.log(element);
        if (dynamicstring === '') {
            dynamicstring = "/// <summary>\n" +
                "/// Represents the " + element + '\n' +
                "/// </summary>" + '\n' +
                dataType + " " + element + " { get; set; }" + '\n\n';
        } else {
            dynamicstring += "/// <summary>\n" +
                "/// Represents the " + element + '\n' +
                "/// </summary>" + '\n' +
                dataType + " " + element + " { get; set; }" + '\n\n';
        }
    }, this);

    return dynamicstring;
}

function Privatevariables() {
    var dynamicstring = '';
    var arr;
    arr = Object.keys(jsonObj[0]);
    arr.forEach(function(element) {
        var underscoreParam = element.replace(element.charAt(0), '_' + element.charAt(0).toLowerCase());
        dynamicstring += dynamicstring = 'private PropertyAttributes ' + underscoreParam + ';\n';
    }, this);
    return dynamicstring;
}

function Initialize() {
    var dynamicstring = '';
    var arr;
    arr = Object.keys(jsonObj[0]);
    arr.forEach(function(element) {
        var underscoreParam = element.replace(element.charAt(0), '_' + element.charAt(0).toLowerCase());
        dynamicstring += underscoreParam + ' = GetPropertyAttributes("' + element + '") \n';
    }, this);
    return dynamicstring;
}


function Serializable() {
    var dynamicstring = '';

    var arr;
    arr = Object.keys(jsonObj[0]);
    arr.forEach(function(element) {
        var dataType = Number.isInteger(jsonObj[0][element]) ? 'int' : 'string';
        var underscoreParam = element.replace(element.charAt(0), '_' + element.charAt(0).toLowerCase());
        dynamicstring += '/// <summary>\n' +
            '/// Represents the ' + element + ' \n' +
            '/// </summary> \n' +
            '[XmlAttributeBehavior \n' +
            '(PropertyAttributes.PropertyType.Serializable \n' +
            ', PropertyAttributes.ValueBehavior.SimpleGetterSetter \n' +
            ')] \n' +
            'public ' + dataType + ' ' + element + ' \n' +
            '{ \n' +
            'get { return (' + dataType + ')' + underscoreParam + '.Value; } \n' +
            'set { ' + underscoreParam + '.Value = value; } \n' +
            '}\n\n';

    }, this);
    return dynamicstring;
}






module.exports = function(grunt) {
    console.log(plugins);
    // ===========================================================================
    // CONFIGURE GRUNT ===========================================================
    // ===========================================================================
    grunt.initConfig({

        // get the configuration info from package.json ----------------------------
        // this way we can use things like name and version (pkg.name)
        pkg: grunt.file.readJSON('package.json'),

        // all of our configuration will go here
        jshint: {
            options: {
                reporter: require('jshint-stylish') // use jshint-stylish to make our errors look and read good
            },

            // when this task is run, lint the Gruntfile and all js files in src
            build: ['Grunfile.js', 'app/**/*.js']
        },
        uglify: {
            options: {
                banner: '/*\n <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> \n*/\n',
                report: 'min',
                mangle: false
            },
            build: {
                files: folders
            }
        },
        cssmin: {
            options: {
                banner: '/*\n <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> \n*/\n'
            },
            build: {
                files: [{
                        'dist/css/main.min.css': 'dist/src/main.css'
                    }

                ]

            }
        },
        dev_prod_switch: {
            options: {
                // Can be ran as `grunt --env=dev` or `grunt --env=prod`
                environment: grunt.option('env') || 'dev',
                env_char: '#',
                env_block_dev: 'env:dev',
                env_block_dev: 'SCRIPTS DATA',
                env_block_prod: 'SCRIPTSP DATA',
                env_block_test: 'env:test'
            },
            all: {
                files: {
                    'index.html': 'index.html',
                    'index.js': 'index.js'
                }
            }
        },
        scriptlinker: {
            dev: {
                options: {
                    startTag: '<!-- SCRIPTS DATA -->',
                    endTag: '<!--SCRIPTS END-->',
                    fileTmpl: '<script src="%s"></script>',
                    appRoot: ''
                },
                files: [{
                    // Target-specific file lists and/or options go here. 
                    'index.html': [
                        plugins, 'index.js', 'app/**/*.js'
                    ]
                }],
            },
            prod: {
                options: {
                    startTag: '<!-- SCRIPTSP DATA -->',
                    endTag: '<!--SCRIPTSP END-->',
                    fileTmpl: '<script src="%s"></script>',
                    appRoot: ''
                },
                files: {
                    // Target-specific file lists and/or options go here. 
                    'index.html': [plugins, 'index.js', 'dist/js/*.js']
                },
            },
        },
        concat: {
            options: {
                stripBanners: true,
                banner: '/*! <%= pkg.name %> - v<%= pkg.version %> - ' +
                    '<%= grunt.template.today("yyyy-mm-dd") %> */',
                banner: "'use strict';\n",
                // process: function(src, filepath) {
                //     return '// Source: ' + filepath + '\n' +
                //         src.replace(/(^|\n)[ \t]*('use strict'|"use strict");?\s*/g, '$1');
                // },
                // separator: ';'
            },
            js: { //target
                src: ['app/**/*.js'],
                dest: 'dist/src/main.js'
            },
            css: {
                src: css,
                dest: 'dist/src/main.css'
            }
        },
        copy: {
            images: {
                expand: true,
                cwd: 'src/images/',
                src: ['**/*'],
                dest: 'dist/images/',
                filter: 'isFile',
                flatten: true
            }
        },

        imagemin: { // Task            
            dynamic: { // Another target
                files: [{
                    expand: true, // Enable dynamic expansion
                    cwd: 'src/images', // Src matches are relative to this path
                    src: ['**/*.{png,jpg,gif}'], // Actual patterns to match
                    dest: 'dist/images' // Destination path prefix
                }]
            }
        },


        //grunt  Robot --option-path=testgruntttt

        mkdir: {
            all: {
                options: {
                    create: [CtrlFolder]
                },
            },
        },
        "file-creator": {
            "option": {
                files: [
                    {
                        file: (CtrlFolder+'/' + grunt.option('option-path').split(",")[1] + "Controller.cs"),
                        method: function(fs, fd, done) {
                            done();
                        }
                    },
                    {
                        file: (DalFolder+'/' + grunt.option('option-path').split(",")[1] + "Dal.cs"),
                        method: function(fs, fd, done) {
                            done();
                        }
                    },
                    {
                        file: (SvcFolder+'/' + grunt.option('option-path').split(",")[1] + "Svc.cs"),
                        method: function(fs, fd, done) {
                            done();
                        }
                    },
                    {
                        file: (MlFolder+'/' + grunt.option('option-path').split(",")[1] + "Ml.cs"),
                        method: function(fs, fd, done) {
                            done();
                        }
                    },
                ]
            },
            options: {
                replacements: [{
                    pattern: '@Dynamic',
                    replacement: grunt.option('option-path').split(",")[1]
                }]
            }
        },

        'string-replace': {
            dist: {
                files: [
                    {
                        src: './' + grunt.option('option-path').split(",")[0] + '/Controllers/DynamicController.cs',
                        dest: (CtrlFolder+'/' + grunt.option('option-path').split(",")[1] + "Controller.cs")
                    },
                    {
                        src: './' + grunt.option('option-path').split(",")[0] + '/Dal/DynamicDal.cs',
                        dest: (DalFolder+'/' + grunt.option('option-path').split(",")[1] + "Dal.cs")
                    },
                    {
                        src: './' + grunt.option('option-path').split(",")[0] + '/svc/DynamicSvc.cs',
                        dest: (SvcFolder+'/' + grunt.option('option-path').split(",")[1] + "Svc.cs")
                    },
                    {
                        src: './' + grunt.option('option-path').split(",")[0] + '/Model/DynamicMl.cs',
                        dest: (MlFolder+'/' + grunt.option('option-path').split(",")[1] + "Ml.cs")
                    },
                ],
                options: {
                    replacements: [{
                            pattern: /@Dynamic/g,
                            replacement: grunt.option('option-path').split(",")[1]
                         }
                       // , {
                        //     pattern: /@Parent/g,
                        //     replacement: grunt.option('option-path').split(",")[2]
                        // },
                        // {
                        //     pattern: /@businessObjectInterfaceCs/g,
                        //     replacement: IBusinessObject
                        // },
                        // {
                        //     pattern: /@Privatevariables/g,
                        //     replacement: Privatevariables
                        // }, {
                        //     pattern: /@Initialize/g,
                        //     replacement: Initialize
                        // }, {
                        //     pattern: /@Serializable/g,
                        //     replacement: Serializable
                        // }, {
                        //     pattern: /@businessObjectInterfaceCs/g,
                        //     replacement: IBusinessObject
                        // }, {
                        //     pattern: /@Examples/g,
                        //     replacement: JSON.stringify(jsonObj[0])
                        // }
                    ]
                }
            }
        },

        convertExcelToJson: {
            test: {
                files: [
                    { src: './EXCEL-JSON.xls', dst: 'types.json' }
                ]
            }
        },




    });
    grunt.registerTask('default', ['jshint', 'cssmin', 'concat', 'scriptlinker:dev', 'imagemin']);

    // this task will only run the dev configuration 
    grunt.registerTask('dev', ['jshint', 'cssmin', 'concat', 'scriptlinker:dev', 'imagemin']);

    // only run production configuration 
    grunt.registerTask('prod', ['jshint', 'concat', 'uglify', 'cssmin', 'scriptlinker:prod', 'imagemin']);
    grunt.registerTask('PetDog', ['file-creator', 'string-replace']);

    // ===========================================================================
    // LOAD GRUNT PLUGINS ========================================================
    // ===========================================================================
    // we can only load these if they are in our package.json
    // make sure you have run npm install so our app can find these
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-less');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-dev-prod-switch');
    grunt.loadNpmTasks('grunt-scriptlinker');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-imagemin');
    grunt.loadNpmTasks('grunt-mkdir');
    grunt.loadNpmTasks('grunt-file-creator');
    grunt.loadNpmTasks('grunt-string-replace');
    grunt.loadNpmTasks('grunt-replace');
    grunt.loadNpmTasks('grunt-excel-as-json');
};